using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application.Features.Personel;

public sealed record UpdatePersonelCommand(Guid id,string name, string lastName, string phone, string mail, string city, string town, int age, DateTime? restDay, DateTime? startDate, DateTime? endDate, bool isStartWork, string adress) : IRequest<Result<string>>;