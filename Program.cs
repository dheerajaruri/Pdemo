using System;

namespace Pdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee{Id=1001, Name="Ram", salary=98000};
            Console.WriteLine(employee);
        }
    }
}
