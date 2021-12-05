using FullStackSolution.CrossCutting.Enums;
using FullStackSolution.DTO;

namespace FullStackSolution.Domain.Entities
{
    public class WeekPoint
    {
        public WeekPoint(WeekPointDTO weekPointDTO)
        {
            WeekPointType = weekPointDTO.WeekPointType;
            Name = weekPointDTO.Name;
            Description = weekPointDTO.Description;
            Damage = weekPointDTO.Damage;
        }

        public WeekPointType WeekPointType { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public int Damage { get; private set; }
    }
}
