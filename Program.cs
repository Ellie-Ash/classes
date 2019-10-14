using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeone = new Employee()
            { 
                firstName = "zellie", 
                lastName = "zash", 
                title = "dishwasher", 
                startDate = DateTime.Now 
            };

            Employee employeetwo = new Employee() { 
                firstName = "aellie", 
                lastName = "aaaaaash", 
                title = "dishwasher", 
                startDate = DateTime.Now 
            };

            Company firstCo = new Company();
            firstCo.name = "Haus of Ash";
            firstCo.startDate = DateTime.Now;

            firstCo.addEmployee(employeeone);
            firstCo.listEmployees();
            firstCo.addEmployee(employeetwo);
            firstCo.listEmployees();
        }
    }
}
