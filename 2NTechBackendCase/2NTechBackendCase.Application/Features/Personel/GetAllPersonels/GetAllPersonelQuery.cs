using _2NTechBackendCase.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application.Features.Personel;

public sealed record GetAllPesonelQuery() : IRequest<Result<List<Employee>>>;