using Repeat.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeat.Services
{
    internal class EmployeeService
    {
        public int GetAverageAgeForEmployess()
        {
            Employee[] employees = GetEmployees();

            int sumAge = 0;
            int employeeCount = employees.Length;

            foreach (Employee employee in employees)
            {
                sumAge += employee.Age;
            }

            int result = sumAge / employeeCount;

            return result;
        }

        public void SearchByPosition(string Position)
        {
            var employees = GetEmployees();

            foreach (var item in employees)
            {
                if (item.position.Trim().ToLower().Contains(Position.Trim().ToLower()))
                {
                    Console.WriteLine($"{item.FullName}, Age: {item.Age}, Position: {item.position}");
                }
            }
        }

        private Employee[] GetEmployees()
        {
            Employee emp1 = new()
            {
                Id = 1,
                FullName = "Sheref Tanzilli",
                Age = 26,
                position = "Full stack developer"
            };


            Employee emp2 = new()
            {
                Id = 2,
                FullName = "Cahangir Axundov",
                Age = 20,
                position = "jumping"
            };

            Employee emp3 = new()
            {
                Id = 3,
                FullName = "Pervin Mirzeyev",
                Age = 30,
                position = "Backend developer"
            };

            Employee[] employees = { emp1, emp2, emp3 };

            return employees;
        }
    }
}
