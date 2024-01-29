namespace ArchStore.InMemoryModel
{
    public class ModelChanger
    {
        public void notifyChange(){}
        public void registerModelChanger(ModelChangeObserver o){}
        public void removeModelChanger(ModelChangeObserver o){}
    }
}
