using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class Camera
    {
        private Point3D location;
        private Angle3D angle;

        public void Rotate(Angle3D newAngle)
        {
            this.angle = newAngle;
        }

        public void Move(Point3D newLocation)
        {
            this.location = newLocation;
        }
        public Camera() { }

        public Camera(Point3D location, Angle3D angle)
        {
            this.location = location;
            this.angle = angle;
        }

        public Point3D GetLocation()
        {
            return location;
        }

        public Angle3D GetAngle()
        {
            return angle;
        }
    }
}
