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
			
			
	
			
			//Employee
			
			Employee employee = new Employee("John Doe", "Software Developer", 50000);

            employee.AddPerformanceReview(8);
            employee.AddPerformanceReview(9);
            employee.AddPerformanceReview(7);

            Console.WriteLine($"Performance Reviews: {employee.DisplayPerformanceReviews()}");

            Console.WriteLine($"Average Performance Score: {employee.AveragePerformanceScore}");

            employee.UpdateSalary();
            Console.WriteLine($"New Salary: {employee.Salary}");

            employee.RemovePerformanceReview(7);
            Console.WriteLine($"Performance Reviews after removal: {employee.DisplayPerformanceReviews()}");

            employee.UpdateSalary();
            Console.WriteLine($"Updated Salary after performance update: {employee.Salary}");
    }
}
