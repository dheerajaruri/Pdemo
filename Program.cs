using System;
using System.Collection.Generic;

namespace Pdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee{Id=1001, Name="Ram", salary=98000};
            Console.WriteLine(employee);

            List<Employee> employees = new list<Employee>{
                new Employee{Id=1002, Name="Sai", salary=97000.00}
                new Employee{Id=1003, Name="Gayathri", salary=98000.00}
            };
            foreach(Employee emp in employees)
            Console.WriteLine(emp);
        }
    }
}
