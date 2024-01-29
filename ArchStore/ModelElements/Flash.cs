using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class Flash
    {
        private Point3D location;
        private Angle3D angle;
        private Color color;
        private Power power;

        public void Rotate(Angle3D newAngle)
        {
            this.angle = newAngle;
        }

        public void Move(Point3D newLocation)
        {
            this.location = newLocation;
        }

        public Flash(Point3D location, Angle3D angle, Color color, Power power)
        {
            this.location = location;
            this.angle = angle;
            this.color = color;
            this.power = power;
        }

        public Flash(Point3D location, Angle3D angle)
        {
            this.location = location;
            this.angle = angle;
        }

        public Flash() { }

        public Point3D GetLocation()
        {
            return location;
        }

        public Angle3D GetAngle()
        {
            return angle;
        }

        public Color GetColor()
        {
            return color;
        }

        public Power GetPower()
        {
            return power;
        }
    }
}
