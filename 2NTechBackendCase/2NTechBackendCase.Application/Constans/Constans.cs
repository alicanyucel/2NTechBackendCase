using _2NTechBackendCase.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2NTechBackendCase.Application.Constans
{
    public static class Constants
    {
        public static List<AppRole> GetRoles()
        {
            List<string> roles = new()
        {
            "Admin",
            "Personel"
        };

            return roles.Select(s => new AppRole() { Name = s }).ToList();
        }
    }
}