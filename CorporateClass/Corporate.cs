using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Corporate
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        private List<Employee> _currentEmployees = new List<Employee> { new Employee("Michael Scott", "The Boss", DateTime.Now) };

        // Create a method that allows a caller to add an employee
        public void AddEmployee(IEnumerable<Employee> values)
        {
            _currentEmployees.AddRange(values);
        }

        // Create a method that allows a caller to remove an employee
        public void RemoveEmployee(Employee name)
        {
            _currentEmployees.Remove(name);
        }

        // Create a method that allows a caller to retrieve the list of employees
        public List<Employee> GetEmployees() => _currentEmployees;

        public void ListEmployees()
        {
            Console.WriteLine("Your current employees are:");
            foreach (var item in _currentEmployees)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
        public Corporate(string nameOfCompany, DateTime createdOn)
        {
            Name = nameOfCompany;
            CreatedOn = createdOn;
        }
    }
}
