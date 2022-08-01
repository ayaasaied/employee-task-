using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.Core.Shared;


namespace Admin.Core.Models
{
    public class Languagelevel  //: BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }


        public virtual List<Employee> EmployeeLanguage { get; set; }
    }
}
