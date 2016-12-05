using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWeb.Contracts
{
    interface IUnit
    {
        int HP { get; set; }
        string Name { get; set; }
        bool IsMale { get; }
        int EXP { get; set; }

    }
}