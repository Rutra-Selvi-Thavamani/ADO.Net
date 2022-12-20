using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADO_Entity_DIff_of_Inhert_and_Compo.Models
{
    public class Employee
    {
        [Required]
        public int BusinessEntityID { get; set; }
        [Required]
        public int NationalIDNumber { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public int BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Gender { get; set; }
    }
}