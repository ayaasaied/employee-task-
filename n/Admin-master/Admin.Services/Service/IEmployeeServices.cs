using Admin.Core.Models;
using Admin.Core.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Services.Service
{
    public interface IEmployeeServices
    {

        Task<List<EmployeeVM>> GetAll();
        Task<int> AddAsync(EmployeeVM employee);
        int Update(int id, EmployeeVM employee);
        Task<int> Remove(int id);
        EmployeeVM GetByIdVM(int id);
        Employee GetById(int id);




    }
}
