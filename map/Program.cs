namespace Tetelek
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 2, 2, 3, 5, 4, 2, 1, 0, 2, 5, 8, 7, 9, 10, 12 };


            //Eldöntés tétele
            int searched = 5;
            int i = 0;
            for (; i < numbers.Length; i++)
            {
                // i -be sorra veszi az indexet
                // numbers[i] -be sorra vehetjük az értékeket
                if (numbers[i] == searched)
                {
                    break;
                }
            }
            if (i == numbers.Length)
            {
                Console.WriteLine("nincs");
            }
            else
            {
                Console.WriteLine("van");
            }

            int j = 0;
            for (; j < numbers.Length && numbers[j] != searched; j++){}

            if (j == numbers.Length)
            {
                Console.WriteLine("nincs");
            }
            else
            {
                Console.WriteLine("van");
            }


            // Számlálás tétel
            //{ 1, 2, 3, 5, 4, 2, 1, 0, 2, 5, 8, 7, 9, 10, 11 };
            ushort count = 0;
            for (int k = 0; k < numbers.Length; k++)
            {
                if (numbers[k] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Páros elemek száma: " + count);

            // Kiválasztás tétele
            // bejárjuk, addig amíg nincs páratlan
            int l = 0;
            while (l < numbers.Length && numbers[l] % 2 != 1) // ciklus addig meg, amig a feltétel igaz      
            {
                l++;
            }

            if (l == numbers.Length)
            {
                Console.WriteLine("Nincs páratlan elem");
            }
            else
            {
                Console.WriteLine(l + " indexű az első páratlan");
                Console.WriteLine(numbers[l] + " értékű elem az első páratlan");
            }

            //utolsó?
            int m = numbers.Length - 1;
            while (m >= 0 && numbers[m] % 2 != 1) // ciklus addig meg, amig a feltétel igaz      
            {
                m--;
            }

            if (m == numbers.Length)
            {
                Console.WriteLine("Nincs páratlan elem");
            }
            else
            {
                Console.WriteLine(m + " indexű az utolsó páratlan");
                Console.WriteLine(numbers[m] + " értékű elem az utolsó páratlan");
            }


        }
    }
}
