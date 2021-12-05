using AutoMapper;
using FullStackSolution.DTO;

namespace FullStackSolution.Infra.Mappers.FullStackSolutionProfile
{
    public class FullStackSolutionProfile : Profile
    {
        public FullStackSolutionProfile()
        {
            CreateMap<Domain.Entities.Hero, HeroDTO>();
            CreateMap<Domain.Entities.Power, PowerDTO>();
            CreateMap<Domain.Entities.WeekPoint, WeekPointDTO>();
        }
    }
}
