using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Admin.Core.Shared;
using System.Threading.Tasks;

namespace Admin.Core.Models
{
    public class Language //:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
        public virtual List<Languagelevel> Languagelevel { get; set; }


    }
}
