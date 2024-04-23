using AutoMapper;
using WebApi.Domain.DTOs;
using WebApi.Domain.Model.EmployeeAggregate;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApi.Application.Mapping
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Employee, EmployeeDTO>()
                .ForMember(dest => dest.NameEmployee, m => m.MapFrom(orig => orig.name));
        }
    }
}