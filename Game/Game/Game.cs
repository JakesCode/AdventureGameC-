using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public List<GameItem> Items = new List<GameItem>();
        public List<GameLocation> Locations = new List<GameLocation>();

        public class GameItem
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public class GameLocation
        {
            // Unique Information //
            public string Name { get; set; }
            public string Description { get; set; }
            public List<GameItem> Items { get; set; }

            // Map Navigation //
            public GameLocation North { get; set; }
            public GameLocation East { get; set; }
            public GameLocation South { get; set; }
            public GameLocation West { get; set; }
        }

        public class GameWorld
        {
            public List<GameLocation> Locations { get; set; }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            // Items //
            foreach (KeyValuePair<string, string> Item in new Dictionary<string, string>()
            {
                {"Sword", "A finely crafted blade."},
                {"Shield", "It's made from wood, but surprisingly effective."}
            })
            {
                Items.Add(new GameItem { Name = Item.Key, Description = Item.Value });
            }
        }
    }
}
