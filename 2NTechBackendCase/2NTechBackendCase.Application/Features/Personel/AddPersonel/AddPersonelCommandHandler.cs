using _2NTechBackendCase.Domain.Entities;
using _2NTechBackendCase.Domain.Repositories;
using AutoMapper;
using GenericRepository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application.Features.Personel;

internal sealed class CreatePesonelComamndHandler(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<AddPersonelCommand, Result<string>>
{
    public async Task<Result<string>> Handle(AddPersonelCommand request, CancellationToken cancellationToken)
    {
        Employee employee = mapper.Map<Employee>(request);

        await employeeRepository.AddAsync(employee, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Calısan kaydı yapıldı";
    }
}
