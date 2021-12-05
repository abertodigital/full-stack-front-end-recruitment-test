using FullStackSolution.DTO;

namespace FullStackSolution.Domain.Entities
{
    public class Power
    {
        public Power(PowerDTO powerDTO)
        {
            Name = powerDTO.Name;
            Value = powerDTO.Value;
        }

        public string Name { get; private set; }
        public int Value { get; private set; }
    }
}
