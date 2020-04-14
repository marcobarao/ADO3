using System.Drawing;

namespace Azul
{
    public class Tile
    {
        public int id { get; set; }
        public Color color { get; set; }
        public int penalty { get; set; }

        public Tile() { }
        public Tile(int id)
        {
            this.id = id;
        }
    }
}
