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

        public Person(DataAccess.Person personDta)
        {
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public static int PersonID { get; private set; }

        public static Person getById(int id)
        {
            using (var context = new SchoolEntities())
            {
                var p = (from element in context.People where element.PersonID == id select element).First();
                return MapDTAToBo(p);
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
                    person.Add(MapDTAToBo(p));
                }                  
            }
            return person;
            //for ()
        }

        private static Person MapDTAToBo(DataAccess.Person dta)
        {
            return new Person()
            {
                Id = dta.PersonID,
                FirstName = dta.FirstName,
                FullName = $"{dta.FirstName} {dta.LastName}"
              
            };
        }

       public static Basistraining.Jf.DataAccess.Person MapBoToDTA(Person bo)
        {
            return new Basistraining.Jf.DataAccess.Person
            { 
                FirstName = bo.FirstName,
                LastName = bo.LastName
            };
        }

        public static Person Save()
        {
            //Mapper
            var personDta = MapBoToDTA(this);

            //DB save
            using (var context = new SchoolEntities())
            {
                context.SaveChanges();//richtig
            }
           
            //return
            return new Person(personDta);
        }

        public static Person remove()
        {
            //Mapper
            var personBo = MapDTAToBo(this);

            //DB

            
        }
        //https://www.learnentityframeworkcore.com/dbcontext/adding-data

        //http://www.entityframeworktutorial.net/crud-operation-in-connected-scenario-entity-framework.aspx


    }
}


    

        
    

