using Admin.Core.Models;
using Admin.Infrastucure.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Admin.Infrastucure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Languagelevel> LanguageLevels { get; set; }
        public DbSet<LineofBusiness> LineofBusinesses { get; set; }
        //public DbSet<EmployeeLanguageLevel> employeeLanguagess { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            new EmployeeEntityconfiguration().Configure(builder.Entity<Employee>());


            builder.Entity<Employee>().Property(t => t.Name).IsRequired();

            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //builder.Entity<EmployeeLanguageLevel>()
            //   .HasKey(t => new { t.EmployeeId, t.LanguagelevelId });

            //builder.Entity<Employee>()

            //.HasMany(s => s.LanguageLevels)
            // .WithMany(s => s.Employees);

        }

         





            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();


        }

    }


    }

