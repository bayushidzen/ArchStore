using System.Collections;
using System.Collections.Generic;

namespace Fabric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<IGeneratorItem> fabricList = new List<IGeneratorItem>();
            
            fabricList.Add(new GenGemReward());
            fabricList.Add(new GenGoldReward());

            for (int i = 0; i < 20; i++) 
            {
                int index = Math.Abs(random.Next()%2)==0?0:1;
                IGameItem fabric = fabricList[index].CreateItem();
                fabric.Open();
            }
        }
    }
}
