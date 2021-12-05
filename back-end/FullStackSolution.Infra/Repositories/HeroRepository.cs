using FullStackSolution.Domain.Entities;
using System.Collections.Generic;

namespace FullStackSolution.Infra.Repositories
{
    public static class HeroRepository
    {

        static List<Hero> Heroes = new List<Hero>();

        public static void Insert(Hero hero) => Heroes.Add(hero);
        public static List<Hero> GetAll() => Heroes;
    }
}
