using FullStackSolution.Service;
using FullStackSolution.Tests.DefaultDTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace FullStackSolution.Tests.Integration.Service
{
    [TestClass]
    public class FullStackSolutionServiceTests 
    {
        [TestMethod]
        public async Task SHOULD_CREATE_USER()
        {
            var boilerplateService = new HeroService(mapper);

            var heroDTO = CreateFullStackSolutionDefaultTestDTO.GetDefault();

            var heroId = await boilerplateService.Create(heroDTO);

            //var hero = await boilerplateService.GetById(heroId);

            //hero.Name.Should().Be(heroDTO.Name);
            //hero.Origin.Should().Be(heroDTO.Origin);
        }
    }
}
