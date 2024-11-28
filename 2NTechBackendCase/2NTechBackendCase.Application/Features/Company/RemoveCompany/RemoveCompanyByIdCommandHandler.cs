using _2NTechBackendCase.Application.Features.Company;
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

namespace _2NTechBackendCase.Application;
internal sealed class DeleteCompanyByIdCommandHandler(
  ICompanyRepository companyRepository,
  IUnitOfWork unitOfWork) : IRequestHandler<DeleteCompanyByIdCommand, Result<string>>
{
    public async Task<Result<string>> Handle(DeleteCompanyByIdCommand request, CancellationToken cancellationToken)
    {
        Company? company = await companyRepository.GetByExpressionAsync(p => p.Id == request.Id, cancellationToken);
        if (company is null)
        {
            return Result<string>.Failure("Şiket bulunamadı");
        }

        companyRepository.Delete(company);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Şirket kaydı silindi";
    }
}