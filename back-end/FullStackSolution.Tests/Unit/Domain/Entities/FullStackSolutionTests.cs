using FullStackSolution.Domain.Entities;
using FullStackSolution.Tests.DefaultDTOs;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FullStackSolution.Tests.Unit.Domain.Entities
{
    [TestClass]
    public class FullStackSolutionTests
    {
        [TestMethod]
        public void SHOULD_CREATE_USER()
        {
            var heroDTO = CreateFullStackSolutionDefaultTestDTO.GetDefault();
            var hero = new Hero(heroDTO);

            heroDTO.Name.Should().Be(heroDTO.Name);
            heroDTO.Origin.Should().Be(heroDTO.Origin);
        }
    }
}
