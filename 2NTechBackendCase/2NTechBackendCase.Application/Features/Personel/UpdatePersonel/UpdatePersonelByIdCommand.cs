using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application.Features.Personel;

public sealed record UpdatePersonelCommand(Guid Id,string Name, string LastName, string Phone, string Mail, string City, string Town, int Age, DateTime RestDay, DateTime StartDate, DateTime EndDate, bool IsStartWork, string Address) : IRequest<Result<string>>;