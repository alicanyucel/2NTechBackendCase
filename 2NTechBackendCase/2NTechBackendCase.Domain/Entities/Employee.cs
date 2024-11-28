using _2NTechBackendCase.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NTechBackendCase.Domain.Entities
{
    public sealed class Employee : Entity
    {
        public required string Name { get; set; } = default!;
        public required string LastName { get; set; } = default!;
        public required string Phone { get; set; } = default!;
        public required string Address { get; set; } = default!;
        public required int Age { get; set; } = default!;
        public required string City { get; set; } = default!;
        public required string Town { get; set; } = default!;
        public required string Email { get; set; } = default!;
        public required DateTime StartDate { get; set; } = default!;
        public required DateTime EndDate { get; set; } = default!;
        public required DateTime RestDay { get; set; } = default!;
        public required bool IsStartWork { get; set; } = false;
        // 1 to n relationship
        public required Company Company { get; set; } = default!;
    }

}
