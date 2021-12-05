using FullStackSolution.DTO;
using System.Threading.Tasks;

namespace FullStackSolution.Domain.Services
{
    public interface IHeroService
    {
        Task<string> Create(HeroDTO boilerplateDTO);
    }
}
