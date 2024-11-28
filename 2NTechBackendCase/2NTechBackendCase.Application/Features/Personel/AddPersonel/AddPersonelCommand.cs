using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Result;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2NTechBackendCase.Application;

public sealed record AddPersonelCommand(string name, string lastName, string phone, string mail, string city, string town, int age, DateTime?  restDay, DateTime? startDate, DateTime? endDate, bool isStartWork,string address) : IRequest<Result<string>>;

