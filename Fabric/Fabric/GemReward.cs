﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class GemReward : IGameItem
    {
        public void Open()
        {
            Console.WriteLine("Открыли сундук с алмазами!");
        }
    }
}
