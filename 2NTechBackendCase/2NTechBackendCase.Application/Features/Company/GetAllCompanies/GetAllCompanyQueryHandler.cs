using _2NTechBackendCase.Domain.Entities;
using _2NTechBackendCase.Domain.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application;

internal sealed class GetAllCompanyQueryHandler(ICompanyRepository companyRepository) : IRequestHandler<GetAllCompanyQuery, Result<List<Company>>>
{
    public async Task<Result<List<Company>>> Handle(GetAllCompanyQuery request, CancellationToken cancellationToken)
    {
        List<Company> companies = await companyRepository.GetAll().OrderBy(p => p.Name).ToListAsync(cancellationToken);

        return companies;
    }
}