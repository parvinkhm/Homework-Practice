using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//namespace Repeat.Controllers
//{
//    internal class PersonController
//    {
//        public void CheckUserIsMarried()
//        {
//            Console.WriteLine("Add age");

//            Age: string age = Console.ReadLine();

//            int personAge;

//            bool isCorrectAgeFormat = int.TryParse(age, out personAge);

//            if (isCorrectAgeFormat)
//            {
//                Console.WriteLine("Add full name");
//                string FullName = Console.ReadLine();

//                Console.WriteLine("Are you married ?  Yes/No");

//                Married: string married = Console.ReadLine();

//                bool personIsmarried = false;

//                if(married == "Yes")
//                {
//                    personIsmarried = true;
//                }
//                else if(married == "No")
//                {
//                    personIsmarried = false;
//                }
//                else
//                {
//                    Console.WriteLine("Pls add your married answer again");
//                    goto Married;
//                }

//                Person person = new()
//                {
//                    Id = 1,
//                    FullName = FullName,
//                    Age = personAge,
//                    IsMarrid = personIsmarried


//                };

//                string result = GetPersonMarried(person);

//                Console.WriteLine(result);


//                //Console.WriteLine(isMarried);



//                //Console.WriteLine(person.Id + "-" + person.FullName + "-" + person.Age + "-" + person.IsMarrid);

//            }
//            else
//            {
//                Console.WriteLine("Pls add correst age format again : ");
//                goto Age;
//            }
//        }



//        private string GetPersonMarried(Person person)
//        {
//            PersonService service = new PersonService();

//            bool isMarried = service.CheckIsMarried(person);

//            string result = isMarried == true ? "Evlidir" : "Subaydir";

//            return result;
//        }
//    }
//}
