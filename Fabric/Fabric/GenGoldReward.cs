using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class GenGoldReward : IGeneratorItem
    {
        public IGameItem CreateItem() 
        {
            return new GoldReward();
        }
    }
}
