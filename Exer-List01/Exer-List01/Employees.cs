using System;
using System.Globalization;

namespace Exer_List01 {
    class Employees {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salary { get; private set; }

        public Employees (int id, string nome, double salary) {
            Id = id;
            Nome = nome;
            Salary = salary;
        }

        public void IncrementSalary(double porcentagem) {
            Salary += Salary * porcentagem / 100;
        }

        public override string ToString() {
            return Id
                + " , "
                + Nome
                + " , "
                + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
