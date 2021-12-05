using FullStackSolution.CrossCutting.Enums;
using FullStackSolution.DTO;
using System;

namespace FullStackSolution.Domain.Entities
{
    public class Hero : IModelBase
    {
        public Hero(HeroDTO heroDTO)
        {
            Id = Guid.NewGuid().ToString();
            Name = heroDTO.Name;
            Origin = heroDTO.Origin;
            Power = new Power(heroDTO.Power);
            WeekPoint = new WeekPoint(heroDTO.WeekPoint);
        }

        public string Id { get; set; }
        public string Name { get; private set; }
        public OriginType Origin { get; private set; }
        public Power Power { get; private set; }
        public WeekPoint WeekPoint { get; private set; }
    }
}