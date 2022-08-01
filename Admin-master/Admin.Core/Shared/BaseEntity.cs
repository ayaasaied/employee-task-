using Admin.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Core.Shared
{
    public abstract class BaseEntity:BaseEntityID
    {
        [Required(ErrorMessage = "Name IS Required")]

        public string Name { get; set; }
       // public bool IsDeleted { get; set; }

    }
}
