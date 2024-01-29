using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class Angle3D
    {
        private readonly double xAngle;
        private readonly double yAngle;
        private readonly double zAngle;

        public Angle3D(double xAngle, double yAngle, double zAngle)
        {
            this.xAngle = xAngle;
            this.yAngle = yAngle;
            this.zAngle = zAngle;
        }

        public Angle3D() { }

        public double GetxAngle()
        {
            return xAngle;
        }

        public double GetyAngle()
        {
            return yAngle;
        }

        public double GetzAngle()
        {
            return zAngle;
        }
    }
}
