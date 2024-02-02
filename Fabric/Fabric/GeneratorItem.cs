﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    public interface IGeneratorItem
    {
        public IGameItem CreateItem ();
    }
}
