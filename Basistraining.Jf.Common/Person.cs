using Basistraining.Jf.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basistraining.Jf.Common
{
    public class Person
    {
        private static object context;

        public int Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public static Person getById(int id)
        {
            using (var context = new SchoolEntities())
            {
                var p = (from element in context.People where element.PersonID == id select element).First();
                return Mapper(p);
            }
        }

        public static List<Person> getAll()
        {
            List<Person> person = new List<Person>();

            using (var ctx = new SchoolEntities())
            {
                List<DataAccess.Person> persons = new List<DataAccess.Person>();

                foreach (var p in persons)
                {
                    person.Add(Mapper(p));
                }                  
            }
            return person;
            //for ()
        }

        private static Person Mapper(DataAccess.Person person)
        {
            return new Person()
            {
                Id = person.PersonID,
                FirstName = person.FirstName,
                FullName = $"{person.FirstName} {person.LastName}"
              
            };
        }

        public static BO MapDtaToBo(PersonBO bo)
        {
            return new PersonBO()
            {
                Firstname = bo.firstname,
                Lastname = bo.lastname
            };
        }

        public static DTA MapBoToDta(PersonDTA dta)
        {
            return new PersonDTA()
            {
                Firstname = dta.firstname,
                Lastname = dta.lastname,
            };
        }
    }
}


    

        
    

