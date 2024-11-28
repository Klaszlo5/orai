using System;

namespace PuzzleJatek
{
    public class Puzzle
    {
        private int[,] tabla;
        private const int Meret = 4; // 4x4-es tábla
        private int uresSor;
        private int uresOszlop;

        public Puzzle()
        {
            tabla = new int[Meret, Meret];
            TablaInicializalasa();
            TablaKeveres();
        }

        private void TablaInicializalasa()
        {
            int szam = 1;
            for (int sor = 0; sor < Meret; sor++)
            {
                for (int oszlop = 0; oszlop < Meret; oszlop++)
                {
                    if (sor == Meret - 1 && oszlop == Meret - 1)
                    {
                        tabla[sor, oszlop] = 0;
                    }
                    else
                    {
                        tabla[sor, oszlop] = szam++;
                    }
                }
            }
        }

        private void TablaKeveres()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int irany = rand.Next(4);
                LepesVele(irany);
            }
        }

        public void LepesVele(int irany)
        {
            int ujSor = uresSor;
            int ujOszlop = uresOszlop;

            switch (irany)
            {
                case 0: 
                    ujSor = uresSor - 1;
                    break;
                case 1: 
                    ujSor = uresSor + 1;
                    break;
                case 2: 
                    ujOszlop = uresOszlop - 1;
                    break;
                case 3: 
                    ujOszlop = uresOszlop + 1;
                    break;
            }

            if (ujSor >= 0 && ujSor < Meret && ujOszlop >= 0 && ujOszlop < Meret)
            {
                tabla[uresSor, uresOszlop] = tabla[ujSor, ujOszlop];
                tabla[ujSor, ujOszlop] = 0;
                uresSor = ujSor;
                uresOszlop = ujOszlop;
            }
        }

        public bool Megoldva()
        {
            int szam = 1;
            for (int sor = 0; sor < Meret; sor++)
            {
                for (int oszlop = 0; oszlop < Meret; oszlop++)
                {
                    if (sor == Meret - 1 && oszlop == Meret - 1)
                    {
                        if (tabla[sor, oszlop] != 0)
                            return false;
                    }
                    else
                    {
                        if (tabla[sor, oszlop] != szam++)
                            return false;
                    }
                }
            }
            return true;
        }

        public void TablaMegjelenitese()
        {
            Console.Clear();
            for (int sor = 0; sor < Meret; sor++)
            {
                for (int oszlop = 0; oszlop < Meret; oszlop++)
                {
                    if (tabla[sor, oszlop] == 0)
                    {
                        Console.Write("   "); // Üres hely
                    }
                    else
                    {
                        Console.Write($"{tabla[sor, oszlop],3}");
                    }
                }
                Console.WriteLine();
            }
        }

        public void FelhasznaloBemenet()
        {
            Console.WriteLine("Használja az alábbi billentyűket az üres hely mozgatásához:");
            Console.WriteLine("W - Fel");
            Console.WriteLine("S - Le");
            Console.WriteLine("A - Balra");
            Console.WriteLine("D - Jobbra");
            Console.WriteLine("Q - Kilépés");
            ConsoleKeyInfo billentyu = Console.ReadKey(true);

            int lepes = -1;
            switch (billentyu.Key)
            {
                case ConsoleKey.W: lepes = 0; break; // Fel
                case ConsoleKey.S: lepes = 1; break; // Le
                case ConsoleKey.A: lepes = 2; break; // Balra
                case ConsoleKey.D: lepes = 3; break; // Jobbra
                case ConsoleKey.Q: Environment.Exit(0); break; // Kilépés
            }

            if (lepes != -1)
            {
                LepesVele(lepes);
            }
        }

        public static void Main()
        {
            Puzzle puzzle = new Puzzle();

            Console.WriteLine("Üdvözöljük a 15-ös Puzzle játékban!");
            Console.WriteLine("Próbálja meg rendezi a csempéket számok szerint (1-től 15-ig).");
            Console.WriteLine("Használja a W, A, S, D billentyűket az üres hely mozgatásához és oldja meg a puzzlet.");

            while (!puzzle.Megoldva())
            {
                puzzle.TablaMegjelenitese();
                puzzle.FelhasznaloBemenet();
            }

            puzzle.TablaMegjelenitese();
            Console.WriteLine("\nGratulálunk! Megoldotta a puzzlet!");
        }
    }
}