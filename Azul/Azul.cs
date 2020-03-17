using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azul
{
    public partial class Azul : Form
    {
        public Lobby lobby { get; set; }

        public Azul()
        {
            this.lobby = new Lobby();
            InitializeComponent();

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            this.lobby.listGames(Status.ALL);
            
            lstGames.Items.AddRange(lobby.games);
        }
    }
}
