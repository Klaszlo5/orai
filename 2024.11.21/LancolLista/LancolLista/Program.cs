namespace LancolLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            LinkedListNode<string> node1 = new LinkedListNode<string>("elso");
            node1.Next = new LinkedListNode<string>("masodik");
            node1.Next.Next = new LinkedListNode<string>("harmadik");

            Console.WriteLine(node1.Value);
            Console.WriteLine(node1.Next.Value);
            Console.WriteLine(node1.Next.Next.Value);

            Console.WriteLine();
            Console.WriteLine("LISTA:::");

            LinkedList<string> list = new LinkedList<string>();

            list.Add("first");
            list.Add("second");
            list.Add("third");

            list.AddStart("kiskacsa");

            list.PrintAll();

            Console.WriteLine();

            string removeValue = "barack";
            Console.WriteLine($"'{removeValue}' törlése: {list.Remove(removeValue)}");

            while (list.Remove(removeValue)) { }

            list.PrintAll();

        }
    }
}
