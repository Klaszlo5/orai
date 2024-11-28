using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskManagementSystem
{
    public class Task
    {
        public string Title { get; }
        public string Description { get; }
        public int Priority { get; private set; } // Priority 1-5 (1 = Highest, 5 = Lowest)
        public DateTime Deadline { get; }
        public bool IsCompleted { get; private set; }

        // Constructor
        public Task(string title, string description, int priority, DateTime deadline)
        {
            Title = title;
            Description = description;
            Priority = priority;
            Deadline = deadline;
            IsCompleted = false;
        }

        public void MarkAsComplete()
        {
            IsCompleted = true;
        }

        public void UpdatePriority(int newPriority)
        {
            if (newPriority < 1 || newPriority > 5)
            {
                throw new ArgumentException("Priority must be between 1 and 5.");
            }
            Priority = newPriority;
        }

        public override string ToString()
        {
            return $"{Title} (Priority: {Priority}, Deadline: {Deadline.ToShortDateString()}) - " +
                   (IsCompleted ? "Completed" : "Not Completed");
        }
    }

    public class TaskManager
    {
        private List<Task> tasks;
        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
        }

        public void RemoveTask(string title)
        {
            var task = tasks.FirstOrDefault(t => t.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (task != null)
            {
                tasks.Remove(task);
            }
            else
            {
                throw new ArgumentException("Task not found.");
            }
        }

        public List<Task> GetAllTasks()
        {
            return tasks;
        }
        public List<Task> SortByPriority()
        {
            return tasks.OrderBy(t => t.Priority).ToList();
        }

        // Sort tasks by deadline (ascending)
        public List<Task> SortByDeadline()
        {
            return tasks.OrderBy(t => t.Deadline).ToList();
        }

        // Get tasks that are not completed
        public List<Task> GetIncompleteTasks()
        {
            return tasks.Where(t => !t.IsCompleted).ToList();
        }

        public void DisplayTasks(List<Task> taskList)
        {
            if (taskList.Count == 0)
            {
                Console.WriteLine("No tasks available.");
            }
            else
            {
                foreach (var task in taskList)
                {
                    Console.WriteLine(task.ToString());
                }
            }
        }
    }
}