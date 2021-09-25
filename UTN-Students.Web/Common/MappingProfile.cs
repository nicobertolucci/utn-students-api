using AutoMapper;
using UTN_Students.Models.Models;
using UTN_Students.Web.ViewModels;

namespace UTN_Students.Web.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentVM, Student>()
                .ReverseMap();
            CreateMap<CareerVM, Career>()
                .ReverseMap();
            CreateMap<JobPositionVM, JobPosition>()
                .ReverseMap();
        }
    }
}
