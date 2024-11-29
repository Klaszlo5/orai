


using System.Security.Cryptography.X509Certificates;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string[] words = { "kutya", "auto", "ház", "felhő", "mittudomén" };

            bool[] bools = { true, false, true, false };

            int[] numbers = new int[5]; // {0, 0, 0, 0, 0}

            int[] predefinedNumbers = new int[] { 2, 3, 4, 52, 12, 13, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Tömb elemek");
    
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + ".:" + numbers[i]);
            }

            numbers[4] = 10;
            numbers[3] = 9;
            numbers[2] = 8;
            numbers[1] = 7;
            numbers[0] = 6;

            Console.WriteLine("Tömb elemek");
            PrintArray(numbers);

            Console.WriteLine("Tömb elemek duplázása");
            for (int i = 0; i < numbers.Length; i++)
            {
                //numbers[i] = numbers[i] * 2;
                numbers[i] *= 2;
            }
            //elemek kiírása
            PrintArray(numbers, true);

            Console.WriteLine("Cleaned numbers");
            CleanArray(numbers);
            PrintArray(numbers);

            Console.WriteLine("Predefined tömb elemek");
            PrintArray(predefinedNumbers, true, true);

            Console.WriteLine("Random számok:");
            int[] randoms = GenerateArray(5);
          
            PrintArray(randoms, true, false);

            int largest = FindLargestItem(randoms);
            Console.WriteLine("Legnagyobb érték:" + largest);
            Console.WriteLine("Lenagyobb érték indexe:" + FindLargestsIndex(randoms));

            Console.WriteLine(CalcArrayAverage(randoms));
        }
        private static double CalcArrayAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return (double)sum / array.Length;
        }
        private static int FindLargestItem(int[] array)
        {
            int largest = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
            }
            return largest;
        }
        private static int FindLargestsIndex(int[] array) 
        {
            int largestIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[largestIndex])
                {
                    largestIndex = i;
                }
            }
            return largestIndex;        
        }


        static void CleanArray(int[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        private static int[] GenerateArray(int n)
        {
            int[] newArray = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++) 
            {
                newArray[i] = rnd.Next(0, 11);
            }
            return newArray;
        }

        private static void PrintArray(int[] array, bool withIndex = false, bool humanist = false)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (withIndex)
                {
                   
                    if (humanist)
                    {
                        Console.WriteLine((i + 1) + ". " + array[i]);
                    }
                    else
                    {
                        Console.WriteLine(i + "-" + array[i]);
                    }

                    continue;
                }
                Console.WriteLine(array[i]);
            }
        }




    }
}
