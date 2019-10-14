
using System;
using System.Collections.Generic;

namespace classes {
    public class Company {
        public string name {get; set;} = "Resturante de Ellie";
        public List<Employee> currentEmployees {get; set;} = new List<Employee>();

        // public Company()
        // {
        //     currentEmployees = new List<Employee>();
        // }
        public DateTime startDate {get; set;} = DateTime.Now;
        public void addEmployee(Employee name)
        {
            currentEmployees.Add(name);
        }
        public void listEmployees()
        {
            foreach(Employee employee in currentEmployees){
            Console.WriteLine($"Name: {employee.firstName} {employee.lastName}");
            }
        }
    }
}