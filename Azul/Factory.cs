using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azul
{
    public class Factory
    {
        public int id { get; set; }
        public BindingList<Tile> tiles = new BindingList<Tile>();

        public Factory(int id)
        {
            this.id = id;
        }
    }
}
