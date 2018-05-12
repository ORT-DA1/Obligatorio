using System.Collections.Generic;
using System.Drawing;

namespace Domain.Entities
{
    public class Grid
    {
        public string GridName { get; set; }
        public Client Client { get; set; }
        public Designer Designer { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public List<Wall> Walls { get; set; }
        public List<WallBeam> WallBeams { get; set; }
        public List<Opening> Openings { get; set; }
        private int pixelConvertionForGrid = 25;
        private Pen gridPen;

        public Grid() { }

        public Grid (string gridName, Client client, int height, int width)
        {
            this.Walls = new List<Wall>();
            this.WallBeams = new List<WallBeam>();
            this.Openings = new List<Opening>();

            this.GridName = gridName;
            this.Client = client ;
            this.Height = height * pixelConvertionForGrid; 
            this.Width = width * pixelConvertionForGrid;

            this.gridPen = new Pen(Color.Black, 2);
        }

        public void DrawGrid(Graphics graphic)
        {
            this.DrawX(graphic);
            this.DrawY(graphic);
        }

        private void DrawX(Graphics graphic)
        {
            for (int i = this.pixelConvertionForGrid; i < this.Height; i += this.pixelConvertionForGrid)
            {
                Point startPoint = new Point(0, i);
                Point endPoint = new Point(this.Width, i);

                graphic.DrawLine(gridPen, startPoint, endPoint);

            }
        }

        private void DrawY(Graphics graphic)
        {
            for (int i = this.pixelConvertionForGrid; i < this.Width; i += this.pixelConvertionForGrid)
            {

                Point startPoint = new Point(i, 0);
                Point endPoint = new Point(i, this.Height);

                graphic.DrawLine(gridPen, startPoint, endPoint);
            }
        }

        public bool validateWall(Wall wall)
        {
            return true;
        }

        public void AddWall(Wall wall)
        {
            /*if (validateWall(wall))
            {
                this.Walls.Add(wall);
            }*/
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

        public override bool Equals(object gridObject)
        {
            bool isEqual = false;
            if (gridObject != null && this.GetType().Equals(gridObject.GetType()))
            {
                Grid grid = (Grid)gridObject;
                if ((this.Client.Equals(grid.Client)))
                {
                    isEqual = true;
                }

            }
            return isEqual;
        }

    }
}
