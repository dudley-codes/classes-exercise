using System;
using System.Collections.Generic;

namespace Classes
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create an instance of a company. Name it whatever you like.
      var acme = new Company("Acme, Inc", new DateTime(1950, 1, 3));
      // Create three employees
      acme.addEmployee(new Employee("Lizzie", "Borden", "lumberjack", new DateTime(1952, 1, 1)));
      acme.addEmployee(new Employee("Jack", "The Ripper", "barber", new DateTime(1975, 1, 1)));
      acme.addEmployee(new Employee("Jeffrey", "Dahmer", "chef", new DateTime(1966, 6, 6)));

      // Assign the employees to the company
      // List<Employee> currentEmployees = new List<Employee>();
      // currentEmployees.Add(jack);
      // currentEmployees.Add(lizzie);
      // currentEmployees.Add(jeff);
      /*
          Iterate the company's employee list and generate the
          simple report shown above
      */

      acme.ListEmployees();

    }
  }
}
