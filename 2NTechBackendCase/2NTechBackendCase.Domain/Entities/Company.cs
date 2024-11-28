using _2NTechBackendCase.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _2NTechBackendCase.Domain.Entities
{
    public sealed class Company : Entity

    {
        public required string Name { get; set; } = default!;
        public required string Phone { get; set; } = default!;
        public required string Mail { get; set; } = default!;
        public required string City { get; set; } = default!;
        public required string Town { get; set; } = default!;
        // 1 to n relationship
        public  ICollection<Employee> Employees { get; set; }= default!;
        public  string FullAddress => string.Join(", ", Name, Phone, Mail, City, Town);
    }

}