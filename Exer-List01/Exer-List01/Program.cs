using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exer_List01 {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employees> list = new List<Employees>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Employees #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employees(id, name, salary));
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int serId = int.Parse(Console.ReadLine());

            Employees emp = list.Find(x => x.Id == serId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncrementSalary(porcentagem);
            }
            else {
                Console.WriteLine("This id does not exist: ");
            }
            Console.WriteLine();
            Console.WriteLine("Updaded list of employees: ");
            foreach (Employees obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}
