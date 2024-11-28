using _2NTechBackendCase.Application.Features.Company.AddCompany;
using _2NTechBackendCase.Domain.Repositories;
using AutoMapper;
using GenericRepository;
using MediatR;
using TS.Result;
using _2NTechBackendCase.Domain.Entities;

namespace _2NTechBackendCase.Application.Features;
internal sealed class AddCompanyComamndHandler(ICompanyRepository companyRepository, IUnitOfWork unitOfWork, IMapper mapper) : IRequestHandler<AddCompanyCommand, Result<string>>
{
    public async Task<Result<string>> Handle(AddCompanyCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Company company = mapper.Map<Domain.Entities.Company>(request);
        await companyRepository.AddAsync(company, cancellationToken);
        await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Şirket kaydı yapıldı";
;
    }
}
