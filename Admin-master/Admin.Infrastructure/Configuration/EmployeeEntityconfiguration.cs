using Admin.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Infrastucure.Configuration
{
    public class EmployeeEntityconfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(s=>s.Id);
            builder.Property(builder => builder.Name).IsRequired().HasMaxLength(50);
           
            builder.Property(s=>s.NationalId).IsRequired().HasMaxLength(14);
            builder.Property(s=>s.DateOfBirth).IsRequired();
            //builder.HasMany(x => x.).WithOne(x => x.Employee).HasForeignKey(x => x.);
            //builder.HasQueryFilter(x => !x.IsDeleted);
        }
    }
}
