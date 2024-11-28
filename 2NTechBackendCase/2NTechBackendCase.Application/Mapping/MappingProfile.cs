using _2NTechBackendCase.Application.Features.Company;
using _2NTechBackendCase.Application.Features.Company.AddCompany;
using _2NTechBackendCase.Application.Features.Personel;
using _2NTechBackendCase.Domain.Entities;
using AutoMapper;

namespace _2NTechBackendCase.Application.Mapping
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddEmployeeCommand, Company>().ReverseMap();
            CreateMap<UpdateCompanyCommand, Company>().ReverseMap();
            CreateMap<AddPersonelCommand, Employee>().ReverseMap();
            CreateMap<UpdatePersonelCommand, Employee>().ReverseMap();
           
        }
    }
}
