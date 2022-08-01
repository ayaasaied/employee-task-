using Admin.Core.Models;
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
    public class LkpBaseRepository : ILkpServices //: ILkpServices<Language>
    {
        private readonly ApplicationDbContext _dbContext;
        public LkpBaseRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;


        public async Task<List<Account>> GetAllLAcount()
        {

            var getall = await _dbContext.Accounts.ToListAsync();
            return getall;
        }

        public async Task<List<Language>> GetAllLanguge()
        {
            var getall = await _dbContext.Languages.ToListAsync();
            return getall;
        }

        public async Task<List<Languagelevel>> GetAllLangugeLevel()
        {
            var getall = await _dbContext.LanguageLevels.ToListAsync();
            return getall;
        }

        public List<LineofBusiness> LineOfBussinessId(int id)
        {
            try
            {
                var lineOfBussiness = _dbContext.LineofBusinesses.Where(x => x.AccountId == id).ToList();
                if (lineOfBussiness != null)
                {
                    return lineOfBussiness;
                }


            }
            catch (Exception) { throw; }

            return null;
        }
        public List<Languagelevel> LanguagelevelId(int id)
        {
            try
            {
                var lineOfBussiness = _dbContext.LanguageLevels.Where(x => x.LanguageId == id).ToList();
                if (lineOfBussiness != null)
                {
                    return lineOfBussiness;
                }


            }
            catch (Exception) { throw; }

            return null;
        }

        public List<Employee> EmployeebyAccountId(int id)
        {
            try
            {
                var EmpbyaccountId = _dbContext.Employees.Where(x => x.AccountId == id).ToList();
                if (EmpbyaccountId != null)
                {
                    return (List<Employee>)EmpbyaccountId;
                }


            }
            catch (Exception) { throw; }

            return null;
        }

        public async Task<List<LineofBusiness>> GetAllLineOfBussiness()
        {
            var getall = await _dbContext.LineofBusinesses.ToListAsync();
            return getall;
        }



    }
}
