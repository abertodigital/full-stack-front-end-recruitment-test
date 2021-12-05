using FullStackSolution.CrossCutting.Enums;

namespace FullStackSolution.DTO
{
    public record WeekPointDTO
    {
        public WeekPointType WeekPointType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Damage { get; set; }
    }
}
