using System;

namespace Delegates
{
    public delegate int MathOperation(int number);

    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperation operation = Triple;
            Console.WriteLine(operation(12));

            MathOperation operation1 = delegate (int x)
            {
                return x * 2; 
            };
            Console.WriteLine(operation1(3)); 

            MathOperation operation2 = param => param * 3; 
            Console.WriteLine(operation2(4));  // 4 * 3 = 12

            Action action = () => { Console.WriteLine("Paraméter nélküli Action"); };
            action();

            Action<int, int> actionWith2Param = (x, y) => { Console.WriteLine("A két megadott érték összege: " + (x + y)); };
            actionWith2Param(1, 2);

            Action<string> printAction = (text) => { Console.WriteLine("Print:: " + text); };
            printAction("Hello World!");

            Action test = TestMessage;
            test();

            Console.WriteLine("FUNC");

            Func<int> randomNumber = () => 123;
            Console.WriteLine("randomNumber: " + randomNumber());

            Func<int, int> squareFunc = (x) => x * x;
            Console.WriteLine("squareFunc(4): " + squareFunc(4));
            Console.WriteLine("squareFunc(3): " + squareFunc(3));  // 3 * 3 = 9

            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine("addFunc(2, 3): " + addFunc(2, 3));  // 2 + 3 = 5

            Predicate<string> isShort = (x) => x.Length < 5;
            Console.WriteLine("isShort('Hi'): " + isShort("Hi"));  // True
            Console.WriteLine("isShort('Hello'): " + isShort("Hello"));  // False
        }

        static void TestMessage()
        {
            Console.WriteLine("TestMessage");
        }

        public static int Double(int x) => x * 2;
        public static int Triple(int x) => x * 3;
    }
}