using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestWeb.Contracts;

namespace TestWeb.Models
{
    public class FireGun : Weapon
    {
        public override ItemType GetItemType => ItemType.Fire;

        public override WeaponType GetWeaponType => WeaponType.Group;

        public override int HP
        {
            get
            {
                return 10;
            }

            set
            {
                HP = value;
            }
        }

        public override string Name
        {
            get
            {
                return "FireGun";
            }

            set
            {
                Name = value;
            }
        }
    }
}