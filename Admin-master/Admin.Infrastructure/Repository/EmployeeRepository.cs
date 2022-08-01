using Admin.Core.Models;
using Admin.Core.ViewModel;
using Admin.Infrastucure.Data;
using Admin.Services.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeServices
    {
        private readonly ApplicationDbContext _dbContext;
        public EmployeeRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;
        

        public async Task<List<EmployeeVM>> GetAll()
        {
            try
            {

                var employees = await _dbContext.Employees.Where(z => z.IsActive)
                 .Select(Employee => new EmployeeVM
                 {
                     Id=Employee.Id,
                     Name = Employee.Name,
                     NationalId = Employee.NationalId,
                     DateOfBirth = Employee.DateOfBirth,
                     AccountId = Employee.AccountId,
                     LineofBusinessId = Employee.LineofBusinessId,
                     langugeId=Employee.LanguageId,
                     Account=Employee.Account,
                     LineofBusiness=Employee.LineofBusiness,
                     Language=Employee.Language,
                    // Languagelevels=Employee.EmployeeLanguageLevel.Where(s=>s.Id==Employee.Id).ToList(),

                     

                 }).ToListAsync();


                return (employees ?? null);

            }
            catch (Exception)
            {
                throw;
            }

        }

        public EmployeeVM GetByIdVM(int id)
        {
            try {
                var Employee = _dbContext.Employees.Where(z => z.IsActive).SingleOrDefault(c => c.Id == id);
                if (Employee != null)
                {
                    return new EmployeeVM
                    {
                        Name = Employee.Name,
                        NationalId = Employee.NationalId,
                        DateOfBirth = Employee.DateOfBirth,
                        AccountId = Employee.AccountId,
                        LineofBusinessId = Employee.LineofBusinessId,
                        langugeId = Employee.LanguageId,



                    };
                }


        }
            catch (Exception) { throw; }

            return null;
        }
        public Employee GetById(int id)
        {
            try
            { 
                var Employee = _dbContext.Employees.Where(z => z.IsActive).SingleOrDefault(c => c.Id == id);
                if(Employee != null)
                {
                    return Employee;
                }

              
            }
            catch (Exception) { throw; }

            return null;
        }

        public async Task<int> AddAsync(EmployeeVM employee)
        {
            try
            {
                var emp = new Employee()
                {
                    AccountId = employee.AccountId,
                    DateOfBirth = employee.DateOfBirth,
                    NationalId = employee.NationalId,
                    Name = employee.Name,
                    LineofBusinessId = employee.LineofBusinessId,
                    LanguageId=employee.langugeId,

                };

                await _dbContext.Employees.AddAsync(emp);
                foreach (int lvlID in employee.langaugeslevelids)
                {
                    _dbContext.LanguageLevels.FirstOrDefault(l => l.Id == lvlID).EmployeeLanguage.Add(emp);
                }
               // var result = await _dbContext.SaveChangesAsync();


                return 1;
            }
            catch (Exception) { return 0; }

            return 0;

        }


        public int Update(int id, EmployeeVM NewemployeeVM)
        {
            try
            {
                Employee oldEmp =GetById(id);

                if (oldEmp != null)
                {
                    oldEmp.Name = NewemployeeVM.Name;
                    oldEmp.NationalId = NewemployeeVM.NationalId;
                    oldEmp.DateOfBirth = NewemployeeVM.DateOfBirth;
                    oldEmp.AccountId = NewemployeeVM.AccountId;
                    oldEmp.LineofBusinessId = NewemployeeVM.LineofBusinessId;
                    oldEmp.LanguageId = NewemployeeVM.langugeId;

                    //create a list of Languagelevels came from newemployeevm.langaugeslevelids list filtering the _dbContext.LanguageLevels
                    List<Languagelevel> newLangLevels = _dbContext.LanguageLevels
                        .Where(l => NewemployeeVM.langaugeslevelids.Contains(l.Id)).ToList();
                    oldEmp.EmployeeLanguageLevel = newLangLevels;

                    //_dbContext.SaveChanges();

                }
                return 1;

            }
            catch (Exception)
            {
                throw;
            }

        }

        public async Task<int> Remove(int id)
        {

            try
            {
                var EmpIsActive = GetById(id);

                if (EmpIsActive != null)
                {
                    EmpIsActive.IsActive = false;
                    return 1;
                }


            }
            catch { throw; }

            return 0;
        }


    }
}
