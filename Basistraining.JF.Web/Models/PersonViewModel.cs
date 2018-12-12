using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Basistraining.Jf.Common;


namespace Basistraining.JF.Web.Models
{
	public class PersonViewModel
	{
		public List<Person> PersonenListe { get; set; }

		public PersonViewModel()
		{
			PersonenListe = Jf.Common.Person.getAll();
		}
	}
}