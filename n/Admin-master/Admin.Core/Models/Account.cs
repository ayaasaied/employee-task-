using Admin.Core.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Core.Models
{
    public class Account //:BaseEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
        public virtual List<LineofBusiness> LineofBusinesses { get; set; }

    }
}
