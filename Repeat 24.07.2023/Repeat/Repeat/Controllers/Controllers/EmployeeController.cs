using Repeat.Services;

namespace Repeat.Controllers.Controllers2
{
    internal class EmployeeController
    {
        private EmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }
        public void GetAverageAgeForEmployess()
        {
            //EmployeeService employeeService = new ();
            int averageAge = _employeeService.GetAverageAgeForEmployess();
            Console.WriteLine(averageAge);

           
        }

        public void SearchByPosition()
        {
            //EmployeeService employeeService = new();
            Console.WriteLine("Add search text:");
            string position = Console.ReadLine();
            _employeeService.SearchByPosition(position);
        }

    }
}
