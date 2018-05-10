using System.Collections.Generic;

namespace Domain.Entities
{
    public class Grid
    {
        public Client Client { get; set; }
        public Designer Designer { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Wall> Walls { get; set; }
        public List<Opening> Openings { get; set; }

        public Grid() { }

        public Grid (Designer designer, Client client, int height, int width) {
            this.Designer = designer;
            this.Client = client;
            this.Height = height; 
            this.Width = width;
        }

        public void AddWall(Wall wall)
        {
            //debo pasarle los parametros correctos
            WallBeam wallBeam = new WallBeam();
            AddWallBeam(wallBeam);
        }

        public void AddWallBeam(WallBeam wallBeam)
        {

        }

        public void AddOpening(Opening opening)
        {

        }

        public void RemoveWall(Wall wall)
        {

        }

        public void RemoveWallBeam(Wall wall)
        {

        }

        public void RemoveOpening(Wall wall)
        {

        }


    }
}
