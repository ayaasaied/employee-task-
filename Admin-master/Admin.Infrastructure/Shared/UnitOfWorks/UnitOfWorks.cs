using Admin.Infrastructure.Repository;
using Admin.Infrastucure.Data;
using Admin.Services.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Infrastructure.Shared.UnitOfWorks
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly ApplicationDbContext _context;

        public IEmployeeServices Employee { get; private set; }


        public UnitOfWorks(ApplicationDbContext context)
        {
            _context = context;

            Employee = new EmployeeRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
