using _2NTechBackendCase.Domain.Entities;
using _2NTechBackendCase.Domain.Repositories;
using _2NTechBackendCase.Infrastructure.Context;
using GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NTechBackendCase.Infrastructure.Repositories
{
    internal sealed class EmployeeRepository : Repository<Employee, ApplicationDbContext>, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

    }
}
