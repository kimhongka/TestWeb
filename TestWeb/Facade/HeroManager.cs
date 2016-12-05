using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWeb.Models;

namespace TestWeb.Contracts
{
    public class HeroManager
    {
        private static HeroManager instance;

        private HeroManager() { }

        public static HeroManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HeroManager();
                }
                return instance;
            }
        }

        public List<Hero> GetAllHeroes()
        {
            var fireGun = new FireGun();
            var batmanWeapons = new List<Weapon>();
            batmanWeapons.Add(fireGun);

            var batmanWithFireGun = new Batman(batmanWeapons)
            {
                Name = "fire batman",
                HP = 100
            };
            var heroes = new List<Hero>();
            heroes.Add(batmanWithFireGun);
            heroes.Add(new Wonderwoman(null));

            return heroes;
        }
    }
}