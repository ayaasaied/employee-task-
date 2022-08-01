using Admin.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Infrastructure.Shared.UnitOfWorks
{
    public interface IUnitOfWorks : IDisposable
    {
        IEmployeeServices Employee { get; }


        int Complete();
    }
}
