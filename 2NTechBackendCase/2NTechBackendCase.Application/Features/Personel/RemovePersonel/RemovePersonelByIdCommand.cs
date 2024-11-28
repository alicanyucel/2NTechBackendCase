using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application.Features.Personel;
public sealed record DeletePersonelByIdCommand(
Guid Id) : IRequest<Result<string>>;
