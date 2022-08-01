using Admin.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Core.ViewModel
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long NationalId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; } = true;
        public int AccountId { get; set; }
        public int langugeId { get; set; }
        public Account Account { get; set; }
        public Language Language { get; set; }
        public LineofBusiness LineofBusiness { get; set; }
        public int LineofBusinessId { get; set; }
        public List<Language> Languages { get; set; }

        public List<int> langaugeslevelids { get; set; }

       public List<Languagelevel> Languagelevels { get; set; }

        

    }
}
