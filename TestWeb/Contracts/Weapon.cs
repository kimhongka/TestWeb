using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Contracts
{
    public abstract class Weapon : IItem
    {

        public abstract int HP { get; set; }
        public abstract string Name { get; set; }
        public abstract WeaponType GetWeaponType { get; }
        public abstract ItemType GetItemType { get; }
        public enum WeaponType
        {
            Group = 0,
            Target = 1
        }
        public enum ItemType
        {
            Fire = 0,
            Water = 1,
            Soil = 2
        }
    }
}