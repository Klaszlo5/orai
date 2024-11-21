namespace Korhatar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Film1", 1500);

            movie1.Rating(1);
            movie1.Rating(1);
            movie1.Rating(2);
            movie1.Rating(3);
            movie1.Rating(4);
            movie1.Rating(5);
            movie1.Rating(5);
            movie1.Rating(1);
            movie1.Rating(1);
            movie1.Rating(1);
            movie1.Rating(4);

            Console.WriteLine(movie1.Average);

            Movie movie2 = new Movie("Film2", 2000);
            Console.WriteLine(movie2.Average);
        }
    }
}
