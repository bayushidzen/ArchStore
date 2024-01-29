using System.Collections.ObjectModel;
using ArchStore.ModelElements;

namespace ArchStore.InMemoryModel
{
    internal class ModelStore : ModelChanger
    {
        private readonly Collection<PoligonalModel> poligonalModels = new Collection<PoligonalModel>();
        private readonly Collection<Scene> scenes = new Collection<Scene>();
        private readonly Collection<Flash> flashes = new Collection<Flash>();
        private readonly Collection<Camera> cameras = new Collection<Camera>();
        private readonly Collection<ModelChangeObserver> changeObservers = new Collection<ModelChangeObserver>();

        public void AddPoligonalModel(PoligonalModel model)
        {
            poligonalModels.Add(model);
            this.notifyChange();
        }

        public void RemovePoligonaModel(PoligonalModel model)
        {
            poligonalModels.Remove(model);
            this.notifyChange();
        }

        public void AddScene(Scene scene)
        {
            scenes.Add(scene);
            this.notifyChange();
        }

        public void RemoveScene(Scene scene)
        {
            scenes.Remove(scene);
            this.notifyChange();
        }

        public Scene GetScene(int id)
        {
            foreach (Scene scene in scenes)
            {
                if (scene.GetId() == id)
                {
                    return scene;
                }
            }
            return null;
        }

        public void AddCamera(Camera camera)
        {
            cameras.Add(camera);
            this.notifyChange();
        }

        public void RemoveCamera(Camera camera)
        {
            cameras.Remove(camera);
            this.notifyChange();
        }

        public void AddFlash(Flash flash)
        {
            flashes.Add(flash);
            this.notifyChange();
        }

        public void RemoveFlash(Flash flash)
        {
            flashes.Remove(flash);
            this.notifyChange();
        }

    public void NotifyChange()
        {
            foreach (ModelChangeObserver observer in changeObservers)
            {
                observer.applyUpdateModel();
            }
        }

    public void RegisterModelChanger(ModelChangeObserver o)
        {
            changeObservers.Add(o);
        }

    public void RemoveModelChanger(ModelChangeObserver o)
        {
            changeObservers.Remove(o);
        }

        public Collection<PoligonalModel> GetPoligonalModels()
        {
            return poligonalModels;
        }

        public Collection<Scene> GetScenes()
        {
            return scenes;
        }

        public Collection<Flash> GetFlashes()
        {
            return flashes;
        }

        public Collection<Camera> GetCameras()
        {
            return cameras;
        }

    }
}
