using Admin.Core.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Infrastructure.Configuration
{
    public class Employee : AbstractValidator<Core.Models.Employee>
    {
        public Employee()
        {
            RuleFor(employee => employee.NationalId).NotNull().WithMessage("nathional id is 14");
            RuleFor(employee => employee.DateOfBirth).NotNull().WithMessage("date of birth must bigger than 18");


        }
    }
}

