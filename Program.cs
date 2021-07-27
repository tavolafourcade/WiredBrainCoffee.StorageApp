using System;
using WiredBrainCoffee.StorageApp.Entities;
using WiredBrainCoffee.StorageApp.Repository;

namespace WiredBrainCoffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee { FirstName = "Laura" });
            employeeRepository.Add(new Employee { FirstName = "Rachel" });
            employeeRepository.Add(new Employee { FirstName = "Octavio" });
            employeeRepository.Save();

            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Name = "PluralSight" });
            organizationRepository.Add(new Organization { Name = "Globomantics" });
            organizationRepository.Add(new Organization { Name = "Udemy" });
            organizationRepository.Save();

            Console.ReadLine();
        }
    }
}
