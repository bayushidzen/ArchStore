using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class Point3D
    {
        private double x, y, z;

        public Point3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Point3D() { }

        public double GetX()
        {
            return x;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public double GetY()
        {
            return y;
        }

        public void SetY(double y)
        {
            this.y = y;
        }

        public double GetZ()
        {
            return z;
        }

        public void SetZ(double z)
        {
            this.z = z;
        }
    }
}
