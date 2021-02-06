using System;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var chrisLojo = new Employee("Chris LoJacono", "Janitor", DateTime.Now);
            var ryanMcnair = new Employee("Ryan Mcnair", "Manager", DateTime.Now);
            var josephMartin = new Employee("Joseph Martin", "Assistant to the Regional Manager", DateTime.Now);

            var dunderMifflin = new Corporate("Dunder Mifflin", DateTime.Now);

            var dunderMifflinEmployees = new List<Employee> { chrisLojo, ryanMcnair, josephMartin };

            dunderMifflin.AddEmployee(dunderMifflinEmployees);


            dunderMifflin.RemoveEmployee(josephMartin);
            dunderMifflin.ListEmployees();
            
        }
    }
}
