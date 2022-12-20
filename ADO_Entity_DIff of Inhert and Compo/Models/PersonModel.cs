using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADO_Entity_DIff_of_Inhert_and_Compo.Models
{
    public class PersonModel
    {
        [Key]
        public int BusinessEntityID { get; set; }
       
        public string PersonType { get; set; }
        
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EmailPromotion { get; set; }
        public List<PersonModel> ShowallPerson { get; set; }

    }
}