using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using TestWeb.Contracts;

namespace TestWeb.Models
{
    public class Batman : Hero
    {

        public Batman(List<Weapon> weapons)
        {
            //NinjectIoc.Kernel.Inject(this);
            EXP = 0;
            MAXEXP = 5;
            LEVEL = 1;
            HP = 5;
            Name = "Batman";
            Weapons = weapons;
            IncreaseExperince = OnIncreaseExperince;


        }
        public List<Weapon> Weapons { get; set; }

        public override int HP { get; set; }

        public override bool IsMale => true;

        public override string Name { get; set; }

        public override HeroType GetHeroType => HeroType.Attck;

        public override Type GetWhoHero => typeof(Batman);
        public Task<bool> KillAtOnce(Hero targetHero)
        {
            var isDead = true;
            return Task.Run(() => isDead);
        }

        public async Task Test()
        {
            Console.WriteLine("async .........");
            await Task.Delay(1000);
            Console.WriteLine("finish");
        }

        public bool OnIncreaseExperince(int increasingExp)
        {
            var isLevelUp = false;
            EXP = EXP + increasingExp;
            if (EXP >= MAXEXP)
            {
                LEVEL++;
                EXP -= MAXEXP;
                MAXEXP = MAXEXP * 2;
                isLevelUp = true;
            }

            return isLevelUp;
        }

        public override int EXP { get; set; }

        public override int MAXEXP { get; set; }
    }
}