using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement
{
    internal class Employee
    {
        private List<int> performanceReviews;
        private double salary;

        public string Name { get; }
        public string Position { get; }
        public double Salary 
        { 
            get { return salary; } 
            private set { salary = value; } 
        }

        public Employee(string name, string position, double salary)
        {
            Name = name;
            Position = position;
            this.salary = salary;
            performanceReviews = new List<int>();
        }

        public void AddPerformanceReview(int score)
        {
            if (score < 1 || score > 10)
            {
                throw new ArgumentException("A performance score must be between 1 and 10.");
            }

            performanceReviews.Add(score);
        }

        public void RemovePerformanceReview(int score)
        {
            if (performanceReviews.Contains(score))
            {
                performanceReviews.Remove(score);
            }
            else
            {
                throw new ArgumentException("Performance review not found.");
            }
        }

        public double AveragePerformanceScore
        {
            get
            {
                if (performanceReviews.Count == 0)
                {
                    throw new InvalidOperationException("No performance reviews available.");
                }

                return performanceReviews.Average();
            }
        }
        public void UpdateSalary()
        {
            double averageScore = AveragePerformanceScore;

            if (averageScore >= 9)
            {
                salary *= 1.2; // 20% raise
            }
            else if (averageScore >= 7)
            {
                salary *= 1.1; // 10% raise
            }
            else
            {
                salary *= 0.95; // 5% decrease
            }
        }

        public string DisplayPerformanceReviews()
        {
            return performanceReviews.Count == 0 
                ? "No performance reviews available."
                : string.Join(", ", performanceReviews.Select(r => r.ToString()).ToArray());
        }
    }

    public class InvalidPerformanceScoreException : Exception
    {
        public InvalidPerformanceScoreException(string message) : base(message) { }
    }
}