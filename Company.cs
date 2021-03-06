using System;
using System.Collections.Generic;

namespace Classes
{
  public class Company
  {

    // Some readonly properties (let's talk about gets, baby)
    public string Name { get; set; }
    public DateTime CreatedOn { get; set; }

    // Create a public property for holding a list of current employees
    public List<Employee> currentEmployees { get; set; }


    /*
        Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created
            

        The constructor will set the value of the public properties
  
    */
    public void addEmployee(Employee FNG)
    {
      currentEmployees.Add(FNG);
    }
    public Company(string name, DateTime createdOn)
    {
      Name = name;
      CreatedOn = createdOn;
      currentEmployees = new List<Employee>();
    }
    public void ListEmployees()
    {
      foreach (Employee employee in currentEmployees)
      {
        Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate.ToString()}");
      }
    }
  }
}

