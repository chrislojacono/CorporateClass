using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    class Corporate
    {
        public string Name { get; }
        public DateTime CreatedOn { get; }
        private List<Employee> _currentEmployees = new List<Employee> { new Employee("Michael Scott", "The Boss", DateTime.Now) };

        public void AddEmployee(IEnumerable<Employee> values)
        {
            _currentEmployees.AddRange(values);
        }

        public void RemoveEmployee(Employee name)
        {
            _currentEmployees.Remove(name);
        }

        public List<Employee> GetEmployees() => _currentEmployees;

        public void ListEmployees()
        {
            Console.WriteLine("Your current employees are:");
            foreach (var item in _currentEmployees)
            {
                Console.WriteLine($"{item.Name}");
            }
        }
        public Corporate(string nameOfCompany, DateTime createdOn)
        {
            Name = nameOfCompany;
            CreatedOn = createdOn;
        }
    }
}
