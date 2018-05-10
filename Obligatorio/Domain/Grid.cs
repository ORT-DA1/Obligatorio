using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Grid
    {
        public Designer Designer { get; set; }
        public Client Client { get; set; }
        public int Height;
        public int Width;

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

        public void Draw(Graphics graphics)
        {

        }
        

    }
}
