using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics;
using System.Linq;

namespace App
{
    internal class Student
	{
		public string Name { get; private set; }
		public int ID { get; private set; }
		public List<double> Grades { get; private set; }

		public Student(string name, int id)
		{
			Name = name;
			ID = id;
			Grades = new List<double>();
		}

		public void AddGrade(double grade)
		{
			if (grade >= 0 && grade <= 6)
			{
				Grades.Add(grade);
			}
			else
			{
				Console.WriteLine("Érvénytelen érdemjegy! Kérjük, adjon meg egy 0 és 6 közötti értéket.");
			}
		}

		public double GetAverageGrade()
		{
			if (Grades.Count > 0)
			{
				return Grades.Average();
			}
			return 0;
		}

		public override string ToString()
		{
			return string.Format("Név: {0}, ID: {1}, Átlagos érdemjegy: {2:F2}", Name, ID, GetAverageGrade());
		}
	}

    internal class StudentManager
	{
		private List<Student> students;

		public StudentManager()
		{
			students = new List<Student>();
		}

		public void AddStudent(Student student)
		{
			students.Add(student);
		}

		public void RemoveStudent(int id)
		{
			students.RemoveAll(s => s.ID == id);
		}

		public Student FindStudent(int id)
		{
			return students.FirstOrDefault(s => s.ID == id);
		}

		public void ListStudents()
		{
			foreach (var student in students)
			{
				Console.WriteLine(student.ToString());
			}
		}

		public void SaveToFile(string path)
		{
			try
			{
				var jsonData = JsonSerializer.Serialize(students);
				File.WriteAllText(path, jsonData);
				Console.WriteLine("Adatok mentve sikeresen.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Hiba történt a fájl mentésekor: " + e.Message);
			}
		}

		public void LoadFromFile(string path)
		{
			try
			{
				var jsonData = File.ReadAllText(path);
				students = JsonSerializer.Deserialize<List<Student>>(jsonData) ?? new List<Student>();
				Console.WriteLine("Adatok betöltve sikeresen.");
			}
			catch (Exception e)
			{
				Console.WriteLine("Hiba történt a fájl betöltésekor: " + e.Message); 
			}
		}
	}

    internal class Program
    {
        static void Main(string[] args)
        {
            var manager = new StudentManager();

            // Diákok hozzáadása
            var diak1 = new Student("János Marcell", 1);
            diak1.AddGrade(5);
            diak1.AddGrade(4);
            manager.AddStudent(diak1);

            var diak2 = new Student("Kiss Lajos", 2);
            diak2.AddGrade(6);
            diak2.AddGrade(5);
            manager.AddStudent(diak2);

            Console.WriteLine("Diák lista:");
            manager.ListStudents();
            manager.SaveToFile("students.json");

            manager.RemoveStudent(1);
            Console.WriteLine("Diákok listája törlés után:");
            manager.ListStudents();

            manager.LoadFromFile("students.json");
            Console.WriteLine("Adatok betöltése után:");
            manager.ListStudents();
        }
    }
}