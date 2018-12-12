namespace Basistraining.Jf.Common
{
    internal class PersonBO
    {
        public PersonBO()
        {
        }

        public object Firstname { get; set; }
        public object Lastname { get; set; }

        public static PersonBO save()
        {
            //Mapper
            //var personDta = MapBoToDta(this);

            //DB save
            using (var context = new SchoolDBEntities())
            {
                var std = context.Student.First<Student>();
                std.Firstname = "Max";
                    context.SaveChange();//richtig
            }

                //return
                //return new PersonBO(personDta);
        }
           //https://www.learnentityframeworkcore.com/dbcontext/adding-data

           //http://www.entityframeworktutorial.net/crud-operation-in-connected-scenario-entity-framework.aspx



    }
}