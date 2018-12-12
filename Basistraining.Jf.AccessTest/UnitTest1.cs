using System;
using Basistraining.Jf.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basistraining.Jf.Common
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void ConnectionTest()
		{
			using (var context = new SchoolEntities())
			{
				Assert.IsNotNull(context);

				Assert.IsNotNull(context.People);
			}
		}

		[TestMethod]
		public void CommonTest()
		{
			var p = Person.getAll();

			Assert.IsNotNull(p);

			Assert.AreEqual(p.Count, 34);
		}

        //Save/Edit

        //Remove
                //löschen- überprüfen

        //List

        public void saveTest()
        {
            //Person
            var person = new Person
            {
                FirstName = "Max",
                LastName = "Muster"
            };

            using (var context = new SchoolEntities())
            {
                var personResultat = Person.Save();
                Assert.IsNotNull(personResultat);
                
            }
            
            

           
        }
        //selber erstellen
	}
}
