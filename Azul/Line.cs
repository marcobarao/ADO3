using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azul
{
    public class Line
    {
        public int id { get; set; }
        public BindingList<Tile> tiles = new BindingList<Tile>();

        public Line(int id)
        {
            this.id = id;
        }
    }
}