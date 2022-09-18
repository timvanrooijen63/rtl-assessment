using AutoMapper;
using Rtl.WebApi.Models.Api;
using Rtl.WebApi.Models.Dto;
using Cast = Rtl.WebApi.Models.Api.Cast;

namespace Rtl.WebApi.Infrastructure.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Person, Cast>();
            CreateMap<ShowDocument, ShowResponse>()
                .ForMember(f => f.Cast, opt => opt.MapFrom(f => f.Cast.OrderByDescending(o => o.Person.Birthday)
                                                                      .Select(s => s.Person)));
        }
    }
}
