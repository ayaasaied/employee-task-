using Admin.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Services.Service
{
    public interface ILkpServices// <T>
    {
        Task<List<LineofBusiness>> GetAllLineOfBussiness();
        Task<List<Account>> GetAllLAcount();
        Task<List<Language>> GetAllLanguge();
        Task<List<Languagelevel>> GetAllLangugeLevel();
        List<LineofBusiness> LineOfBussinessId(int id);
        List<Employee> EmployeebyAccountId(int id);
        List<Languagelevel> LanguagelevelId(int id);
        




    }
}
