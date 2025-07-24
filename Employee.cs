using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace firstlab
{
    class Employee
    {
        string emp_name;
        double basic_sal, hra, da, tax, g_pay, net_sal;
        public Employee(string name, double sal)
        {
            emp_name = name;
            basic_sal = sal;
        }
        protected void CalculateNetPay()
        {
            hra = basic_sal * 0.15;
            da = 0.1 * basic_sal;
            g_pay = basic_sal + hra + da;
            tax = 0.08 * g_pay;
            net_sal = g_pay - tax;
        }
        protected void display()
        {
            Console.WriteLine("Name: {0}", emp_name);
            Console.WriteLine("Basic Salary: {0}", basic_sal);
            Console.WriteLine("HRA: {0}", hra);
            Console.WriteLine("DA: {0}", da);
            Console.WriteLine("Gross Pay: {0}", g_pay);
            Console.WriteLine("Tax: {0}", tax);
            Console.WriteLine("Net Salary: {0}", net_sal);
        }
        static void Main(string[] args)
        {
            Employee emp=new Employee("pradeep",10000);
            emp.CalculateNetPay();
            emp.display();
            Console.ReadKey();
        }
    }
}
