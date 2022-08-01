using System;
using Admin.Core.Shared;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Core.Models
{
    public class Employee  //:BaseEntity

    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage ="National Id Is Required")]
        [RegularExpression(@"^([1-9]{1})([0-9]{2})([0-9]{2})([0-9]{2})([0-9]{2})[0-9]{3}([0-9]{1})[0-9]{1}$",  ErrorMessage = "National ID is 14 number") ]
       // [Remote(action: "validatNational", controller: "Validetor")]
       // [Index(nameof(NationalId), IsUnique = true, Name = "Unique National Id")]

        public long NationalId { get; set; }
        [Required(ErrorMessage = "Birth date IS Required")]

        // [Remote(action: "validatDate", controller: "Validetor",AdditionalFields = "DateOfBirth")]

        public DateTime DateOfBirth { get; set; } 

        public bool IsActive { get; set; } = true;
        public int AccountId { get; set; }
        [Required(ErrorMessage ="error")]
        public virtual Account Account { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
        public virtual List<Languagelevel> EmployeeLanguageLevel { get; set; }

        public int LineofBusinessId { get; set; }
        public virtual LineofBusiness LineofBusiness { get; set; }

    }
}
