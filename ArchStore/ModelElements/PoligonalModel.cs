using SixLabors.Fonts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchStore.ModelElements
{
    internal class PoligonalModel
    {
        private Collection<Poligon> poligons;
        private Collection<Texture> textures;

        public PoligonalModel(Collection<Poligon> poligons, Collection<Texture> textures)
        {
            this.poligons = poligons;
            this.textures = textures;
        }
        public PoligonalModel(Collection<Poligon> poligons)
        {
            this.poligons = poligons;
        }

        public Collection<Poligon> GetPoligons()
        {
            return poligons;
        }

        public Collection<Texture> GetTextures()
        {
            return textures;
        }

        public void SetTextures(Collection<Texture> textures)
        {
            this.textures = textures;
        }
    }
}
