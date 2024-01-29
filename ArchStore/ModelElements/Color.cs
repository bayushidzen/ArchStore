using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class Color
    {
        private static int counter = 0;
        private int id;
        private String? color;

        public int GetId()
        {
            return id;
        }
        public int SetId()
        {
            id = ++counter;
            return id;
        }

        public String GetColor()
        {
            return color;
        }

        public void SetColor(String color)
        {
            this.color = color;
        }
    }
}
