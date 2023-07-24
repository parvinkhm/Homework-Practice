using Methods_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Services.Services
{
    internal class EmployeService
    {
        public void GetSalary()
        {
            Employes[] employes = GetEmploye();
           
            foreach (var item in employes)
            {
                if (item.Salary > 1000 && item.Salary < 2000) ;
               
                {
                    Console.WriteLine($"Name: {item.Name}, Surname: {item.Surname}, Age: {item.Age}, Salary: {item.Salary}");
                }
            }
            

           
        }
        public Employes[] GetEmploye()
        {
            Employes emp1 = new()
            {
                Id = 1,
                Name = "Abdulla", 
                Surname ="Memmedov",
                Age = 32,
                Salary = 1400
            };


            Employes emp2 = new()
            {
                Id = 2,
                Name = "Azer",
                Surname = "Mehdiyev",
                Age = 36,
                Salary = 1700
            };

            Employes emp3 = new()
            {
                Id = 3,
                Name = "Ilqar",
                Surname = "Rzayev",
                Age = 40,
                Salary = 2500
            };

            Employes[] employees = { emp1, emp2, emp3 };

            return employees;
        }
    }
}
