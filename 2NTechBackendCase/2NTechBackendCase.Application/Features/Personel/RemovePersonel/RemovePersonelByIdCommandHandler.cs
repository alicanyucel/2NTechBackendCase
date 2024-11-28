using _2NTechBackendCase.Domain.Entities;
using _2NTechBackendCase.Domain.Repositories;
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

internal sealed class DeletePersonnelByIdCommandHandler(
IEmployeeRepository employeeRepository,
IUnitOfWork unitOfWork) : IRequestHandler<DeletePersonelByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeletePersonelByIdCommand request, CancellationToken cancellationToken)
    {
        Employee? employee = await employeeRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
        if (employee is null)
        {
            return Result<string>.Failure("Personel bulunamadı.");
        }

        employeeRepository.Delete(employee);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Personel silindi.";
    }
}