namespace roulette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            List<int> ingezet = new List<int>();

            bool loopChecker = true;
            int aantal = 10;
            while (loopChecker == true)
            {
                Console.WriteLine("aantal chips: " + aantal);
                Console.WriteLine("kies een getal tussen de 1 en de 36 of typ stop");
                string input = Console.ReadLine().ToLower();
                bool getalCheck = int.TryParse(input, out int chipGetal);

                if (getalCheck == true && chipGetal > 0 && chipGetal <= 36)
                {
                    ingezet.Add(chipGetal);
                    aantal--;
                }
                if (input == "stop")
                {
                    int win = p.RouletteWheel();
                    Console.WriteLine("rien ne va plus");
                    for (int i = ingezet.Count - 1; i >= 0; i--)
                    {
                        if (ingezet.Contains(win))
                        {
                            Console.WriteLine("je hebt 35 chips verdient");
                            aantal = aantal + 35;
                            ingezet.Remove(win);
                        }
                        else
                        {
                            ingezet.RemoveAt(i);
                        }
                    }
                    if (aantal == 0)
                    {
                        Console.WriteLine("GAME OVER");
                        Environment.Exit(0);
                    }
                }
                if (aantal == 0)
                {
                    int win = p.RouletteWheel();
                    Console.WriteLine("rien ne va plus");
                    for (int i = ingezet.Count - 1; i >= 0; i--)
                    {
                        if (ingezet.Contains(win))
                        {
                            Console.WriteLine("je hebt 35 chips verdient");
                            aantal = aantal + 35;
                            ingezet.Remove(win);
                        }
                        else
                        {
                            ingezet.RemoveAt(i);
                        }
                    }
                    if (aantal == 0)
                    {
                        Console.WriteLine("GAME OVER");
                        Environment.Exit(0);
                    }
                }
            }
        }

        int RouletteWheel()
        {
            Random random = new Random();
            int rouletteGetal = random.Next(1, 37);
            Console.WriteLine("Roulette getal: " + rouletteGetal);
            return rouletteGetal;
        }
    }
}