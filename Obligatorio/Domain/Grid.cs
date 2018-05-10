using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Grid
    {
        private Designer Designer { get; set; }
        private Client Client { get; set; }
        private int Height;
        private int Width;

        public Grid()
        {

        }

        public Grid(Designer designer, Client client, int height, int width)
        {
            this.Designer = designer;
            this.Client = client;
            this.Height = height;
            this.Width = width;
        }
    }
}
