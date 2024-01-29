namespace ArchStore.ModelElements
{
    internal class Texture
    {
        private int id;
        private String texture;
        public Texture(String texture)
        {
            this.texture = texture;
        }
        public int GetId()
        {
            return id;
        }

        public String GetTexture()
        {
            return texture;
        }
    }
}
