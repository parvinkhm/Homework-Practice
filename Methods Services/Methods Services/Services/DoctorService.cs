using Methods_Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Services.Services
{
    internal class DoctorService
    {
        public Doctor[] Doctors()
        {
            Doctor str1 = new()
            {
                Id = 1,
                Name = "Abdulla",
                Surname = "Memmedov",
                Address = "Nermanov",
                Birthday= "new Datetime"
            };


            Doctor str2 = new()
            {
                Id = 1,
                Name = "Orxan",
                Surname = "Kazimov",
                Address = "Genclik",
                Birthday = "new Datetime"
            };

            Doctor str3 = new()
            {
                Id = 1,
                Name = "Vusal",
                Surname = "Feyzullayev",
                Address = "Nesimi",
                Birthday = "new Datetime"
            };

            Doctor[] doctors = { str1, str2, str3 };

            return doctors;
        }
    }
}
