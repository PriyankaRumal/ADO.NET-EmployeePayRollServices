using System;

namespace ADO.Net_PayRollServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To SQL Program");
            EmployeeRepository.GetAllEmployee();
            Console.ReadLine();
        }
    }
}
