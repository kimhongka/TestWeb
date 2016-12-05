using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Contracts
{
    public abstract class Hero : IUnit
    {
        public abstract int HP { get; set; }
        public abstract string Name { get; set; }
        public abstract bool IsMale { get; }

        public abstract HeroType GetHeroType { get; }
        public abstract Type GetWhoHero { get; }

        public Func<int, bool> IncreaseExperince;

        public abstract int EXP { get; set; }

        public abstract int MAXEXP { get; set; }
        public int LEVEL { get; set; }

        public enum HeroType
        {
            Support = 0,
            Attck = 1,
            Dpend = 2

        }
    }
}