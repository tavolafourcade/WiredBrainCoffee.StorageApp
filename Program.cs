using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repository;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            employeeRepository.Add(new Employee { FirstName = "Laura" });
            employeeRepository.Add(new Employee { FirstName = "Rachel" });
            employeeRepository.Add(new Employee { FirstName = "Octavio" });
            employeeRepository.Save();

            Console.ReadLine();
        }
    }
}
