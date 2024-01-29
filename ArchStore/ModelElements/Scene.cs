using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class Scene
    {
        private static int counter = 0;
        private int id;
        private Collection<PoligonalModel> models;
        private Collection<Flash> flashes;
        private Collection<Camera> cameras;

        public Scene() { }
        public Scene(Collection<PoligonalModel> models)
        {
            this.models = models;
        }
        public Scene(Collection<PoligonalModel> models, Collection<Flash> flashes, Collection<Camera> cameras)
        {
            this.models = models;
            this.flashes = flashes;
            this.cameras = cameras;
        }

        public int GetId()
        {
            id = ++counter;
            return id;
        }

        public Collection<PoligonalModel> GetModels()
        {
            return models;
        }

        public void SetModels(Collection<PoligonalModel> models)
        {
            this.models = models;
        }

        public Collection<Flash> GetFlashes()
        {
            return flashes;
        }

        public void SetFlashes(Collection<Flash> flashes)
        {
            this.flashes = flashes;
        }

        public Collection<Camera> GetCameras()
        {
            return cameras;
        }

        public void SetCameras(Collection<Camera> cameras)
        {
            this.cameras = cameras;
        }
    }
}
