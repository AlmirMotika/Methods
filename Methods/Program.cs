using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Calculator
    {
        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        public decimal Add(decimal num1,int num2)
        {
            return num1 + num2;
        }

        public decimal Add(decimal num1,int num2,int num3)
        {
            return num1 + num2 + num3;
        }
    }

    class Employee
    {
        public decimal Salary;
        public virtual decimal CalculateSalary()
        {
            return Salary;
        }
    }
    class SalesEmployee : Employee
    {
        public decimal SalesBonus;
        public override decimal CalculateSalary()
        {
            return Salary + SalesBonus;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calc = new Calculator();
            //int result = calc.Add(1, 6);
            //Console.Write(result);

            SalesEmployee emp = new SalesEmployee();
            emp.Salary = 1000;
            emp.SalesBonus = 200;
            decimal salary = emp.CalculateSalary();

            Console.Write(salary);

            Console.ReadKey();
        }
    }
}
