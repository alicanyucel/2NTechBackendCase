using _2NTechBackendCase.Application.Features.Personel;
using _2NTechBackendCase.Domain.Entities;
using _2NTechBackendCase.Domain.Repositories;
using AutoMapper;
using GenericRepository;
using MediatR;
using TS.Result;

namespace _2NTechBackendCase.Application.Features;

internal sealed class UpdatePersonelCommandHandler(IEmployeeRepository employeeRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdatePersonelCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdatePersonelCommand request, CancellationToken cancellationToken)
    {
        Employee? employee = await employeeRepository.GetByExpressionWithTrackingAsync(P => P.Id == request.id, cancellationToken);
        if (employee == null)
        {
            return Result<string>.Failure("Personel bulunamadı.");
        }
        mapper.Map(request, employee);
        employeeRepository.Update(employee);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Personel bilgileri güncellendi.";

    }
}