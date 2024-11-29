namespace Ciklus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 4, 3, 6, 5, 8, 7, 10, 9 };

            Console.WriteLine("FOR-al:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("FOREACH-el:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Elemek összege:");
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine("\t" + sum);


            string[,] smatrix = {
                {"alma", "körte", "banán"},
                {"szilva", "ananász", "eper" }
            };

            Console.WriteLine("Gyümölcsös string mátrix");
            foreach (var fruit in smatrix)
            {
                Console.WriteLine(fruit);
            }

            //var
            /*
            var a = 1;
            var b = "alma";
            var c = 'e';

            var e;

            int f;
            */



        }
    }
}
