using FullStackSolution.CrossCutting.Enums;
using FullStackSolution.DTO;

namespace FullStackSolution.Tests.DefaultDTOs
{
    public static class CreateFullStackSolutionDefaultTestDTO
    {
        public static HeroDTO GetDefault() => new HeroDTO
        {
            Name = "Nalfu",
            Origin = OriginType.DC,
            Power = {
                Name = "Super força",
                Value = 9999
            },
            WeekPoint =
            {
                Name = "MJ",
                Damage = int.MaxValue,
                Description = "Namorada do peter parker",
                WeekPointType = WeekPointType.Love,
            }
        };
    }
}
