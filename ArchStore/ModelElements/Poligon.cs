using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class Poligon
    {
        private Collection<Point3D> points;

        public Poligon(Collection<Point3D> points)
        {
            this.points = points;
        }
        public Poligon() { }

        public Collection<Point3D> GetPoints()
        {
            return points;
        }
    }
}
