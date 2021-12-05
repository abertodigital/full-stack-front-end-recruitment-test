using AutoMapper;
using FullStackSolution.Domain.Entities;
using FullStackSolution.Domain.Services;
using FullStackSolution.DTO;
using FullStackSolution.Infra.Repositories;
using System.Threading.Tasks;

namespace FullStackSolution.Service
{
    public class HeroService : IHeroService
    {
        private readonly IMapper mapper;

        public HeroService( IMapper mapper)
        {
            this.mapper = mapper;
        }

        public async Task<string> Create(HeroDTO heroDTO)
        {
            var hero = new Hero(heroDTO);
            HeroRepository.Insert(hero);
            return hero.Id;
        }
    }
}
