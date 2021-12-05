using FullStackSolution.CrossCutting.Enums;

namespace FullStackSolution.DTO
{
    public record HeroDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public OriginType Origin { get; set; }
        public PowerDTO Power { get; set; }
        public WeekPointDTO WeekPoint { get; set; }
    }
}
