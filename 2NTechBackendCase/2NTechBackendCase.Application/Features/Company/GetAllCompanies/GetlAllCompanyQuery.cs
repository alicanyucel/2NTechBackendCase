using _2NTechBackendCase.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application;
public sealed record GetAllCompanyQuery() : IRequest<Result<List<Company>>>;