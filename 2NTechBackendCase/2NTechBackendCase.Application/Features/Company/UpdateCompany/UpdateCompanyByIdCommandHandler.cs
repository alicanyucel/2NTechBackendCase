using _2NTechBackendCase.Application.Features.Company;
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

namespace _2NTechBackendCase.Application;

internal sealed class UpdateCompanyCommandHandler(ICompanyRepository companyRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<UpdateCompanyCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
    {
        Company? company = await companyRepository.GetByExpressionWithTrackingAsync(P => P.Id == request.Id, cancellationToken);
        if (company == null)
        {
            return Result<string>.Failure("şirket bulunamadi");
        }
        mapper.Map(request, company);
        companyRepository.Update(company);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Şirket kaydı güncellendi";

    }
}
