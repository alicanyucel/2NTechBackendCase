﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;

namespace _2NTechBackendCase.Application.Features.Company;

public sealed record UpdateCompanyCommand(Guid Id,string Name, string Phone, string Mail, string City, string Town) : IRequest<Result<string>>;