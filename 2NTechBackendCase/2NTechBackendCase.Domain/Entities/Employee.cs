using _2NTechBackendCase.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _2NTechBackendCase.Domain.Entities
{
    public sealed class Employee : Entity
    {
        public required string name { get; set; } = default!;
        public required string lastName { get; set; } = default!;
        public required string phone { get; set; } = default!;
        public required string address { get; set; } = default!;
        public required int age { get; set; } = default!;
        public required string city { get; set; } = default!;
        public required string town { get; set; } = default!;
        public required string mail { get; set; } = default!;
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; } 
        public DateTime? restDay { get; set; }
        public required bool isStartWork { get; set; } = true;
        // 1 to n relationship
        public required  Company Company { get; set; } = default!;
    }

}
