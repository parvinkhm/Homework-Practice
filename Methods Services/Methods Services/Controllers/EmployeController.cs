using Methods_Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Methods_Services.Controllers
{
    internal class EmployeController
    {
       public void GetSalary()
        {
            EmployeService employeService = new EmployeService();
            string salary = Console.ReadLine();
            employeService.GetSalary();


        }
    }
}
