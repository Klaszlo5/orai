using System;
using System.Collections.Generic;
using System.IO;

class Employee
{
    public string Name { get; set; }
    public int ID { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }

    public Employee(string name, int id, string position, double salary)
    {
        Name = name;
        ID = id;
        Position = position;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"N�v: {Name}, Azonos�t�: {ID}, Poz�ci�: {Position}, Fizet�s: {Salary}";
    }

    public void GiveRaise(double amount)
    {
        Salary += amount;
    }
}

class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }
    public void AddEmployee(Employee employee)
    {
        Employees.Add(employee);
    }
    public void RemoveEmployee(int id)
    {
        Employees.RemoveAll(e => e.ID == id);
    }
    public Employee FindEmployee(int id)
    {
        return Employees.Find(e => e.ID == id);
    }
    public void ListEmployees()
    {
        foreach (var employee in Employees)
        {
            Console.WriteLine(employee.ToString());
        }
    }
}

class Company
{
    public List<Department> Departments { get; set; }
    public Company()
    {
        Departments = new List<Department>();
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }
    public void RemoveDepartment(string name)
    {
        Departments.RemoveAll(d => d.Name == name);
    }
    public void ListDepartments()
    {
        foreach (var department in Departments)
        {
            Console.WriteLine(department.Name);
        }
    }
    public void SaveToFile(string path)
    {
        using (StreamWriter sw = new StreamWriter(path))
        {
            foreach (var department in Departments)
            {
                sw.WriteLine($"Oszt�ly: {department.Name}");
                foreach (var employee in department.Employees)
                {
                    sw.WriteLine($"Alkalmazott: {employee.Name}, Azonos�t�: {employee.ID}, Poz�ci�: {employee.Position}, Fizet�s: {employee.Salary}");
                }
                sw.WriteLine();
            }
        }
    }

    public void LoadFromFile(string path)
    {
        Departments.Clear();
        Department currentDepartment = null;

        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("Oszt�ly:"))
                {
                    string departmentName = line.Substring(8).Trim();
                    currentDepartment = new Department(departmentName);
                    Departments.Add(currentDepartment);
                }
                else if (line.StartsWith("Alkalmazott:"))
                {
                    string[] parts = line.Substring(11).Split(',');
                    string name = parts[0].Split(':')[1].Trim();
                    int id = int.Parse(parts[1].Split(':')[1].Trim());
                    string position = parts[2].Split(':')[1].Trim();
                    double salary = double.Parse(parts[3].Split(':')[1].Trim());

                    Employee employee = new Employee(name, id, position, salary);
                    currentDepartment?.AddEmployee(employee);
                }
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Company company = new Company();

        Department hr = new Department("HR");
        Department it = new Department("IT");

        // Alkalmazottak hozz�ad�sa
        hr.AddEmployee(new Employee("Kiss J�zsef", 1, "HR Vezet�", 500000));
        it.AddEmployee(new Employee("Nagy Anna", 2, "Fejleszt�", 600000));

        company.AddDepartment(hr);
        company.AddDepartment(it);

        Console.WriteLine("HR Oszt�ly:");
        hr.ListEmployees();

        Console.WriteLine("\nIT Oszt�ly:");
        it.ListEmployees();

        company.SaveToFile("vallalat_adatok.txt");
        // Adatok bet�lt�se f�jlb�l
        Company newCompany = new Company();
        newCompany.LoadFromFile("vallalat_adatok.txt");

        Console.WriteLine("\nBet�lt�tt adatok:");
        newCompany.ListDepartments();
        foreach (var department in newCompany.Departments)
        {
            Console.WriteLine($"{department.Name} Oszt�ly:");
            department.ListEmployees();
        }
    }
}