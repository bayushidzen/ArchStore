using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    internal class GenGemReward : IGeneratorItem
    {
        public IGameItem CreateItem()
        {
            return new GemReward();
        }
    }
}
