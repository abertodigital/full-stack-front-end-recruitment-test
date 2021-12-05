using FullStackSolution.Domain.Services;
using FullStackSolution.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FullStackSolution.API.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("hero")]
    [ApiController]
    public class FullStackSolutionController : ControllerBase
    {
        private readonly IHeroService heroService;

        public FullStackSolutionController(IHeroService heroService) => this.heroService = heroService;

        [HttpPost]
        public async Task<string> Create([FromBody] HeroDTO boilerplateDTO) => await heroService.Create(boilerplateDTO);
    }
}
