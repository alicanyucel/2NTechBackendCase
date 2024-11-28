using _2NTechBackendCase.Domain.Entities;
using _2NTechBackendCase.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TS.Result;

namespace _2NTechBackendCase.Application.Features.Personel;
internal sealed class GetAllEmployeeQueryHandler(IEmployeeRepository employeeRepository) : IRequestHandler<GetAllPersonelQuery, Result<List<Employee>>>
{
    public async Task<Result<List<Employee>>> Handle(GetAllPersonelQuery request, CancellationToken cancellationToken)
    {
        List<Employee> employees = await employeeRepository.GetAll().OrderBy(p => p.Name).ThenBy(p => p.LastName).ToListAsync(cancellationToken);

        return employees;
    }
}
