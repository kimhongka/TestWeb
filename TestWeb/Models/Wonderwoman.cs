using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWeb.Contracts;

namespace TestWeb.Models
{
    public class Wonderwoman : Hero
    {
        public Wonderwoman(List<Weapon> weapons)
        {
            EXP = 0;
            MAXEXP = 10;
            HP = 2;
            Name = "Wonderwoman";
            Weapons = weapons;
        }
        public List<Weapon> Weapons { get; set; }

        public override int HP { get; set; }

        public override bool IsMale => false;

        public override string Name { get; set; }

        public override HeroType GetHeroType => HeroType.Support;

        public override Type GetWhoHero => typeof(Batman);

        public override int EXP { get; set; }

        public override int MAXEXP { get; set; }
    }
}