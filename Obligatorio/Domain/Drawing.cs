using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Domain
{
    public class Drawing
    {
        private List<Wall> walls;
        private List<WallBeam> wallbeams;
        private Pen gridPen;
        private Pen wallPen;
        private int pixelConvertionForGrid = 25;

        public int width { get; set; }
        public int height { get; set; }

        public Drawing()
        {
            this.walls = new List<Wall>();
        }

        public Drawing(int width, int height)
        {
            this.walls = new List<Wall>();
            this.wallbeams = new List<WallBeam>();

            this.width = width * pixelConvertionForGrid;
            this.height = height * pixelConvertionForGrid;

            this.gridPen = new Pen(Color.Black, 2);
            this.wallPen = new Pen(Color.LightGreen, 7);

        }

        public void AddWall(Wall wall)
        {
            this.walls.Add(wall);
        }

        public List<Wall> GetWalls()
        {
            return this.walls;
        }

        public void RemoveWall()
        {
            Wall lastWall = this.GetWalls().Last();
            this.walls.Remove(lastWall);
        }

        public void DrawWalls(Graphics graphic)
        {
            foreach (var wall in this.walls)
            {
                graphic.DrawLine(this.wallPen, wall.startPoint, wall.endPoint);
            }
        }

        public void DrawGrid(Graphics graphic)
        {
            this.DrawX(graphic);
            this.DrawY(graphic);
        }

        private void DrawX(Graphics graphic)
        {
            for (int i = this.pixelConvertionForGrid; i < this.height; i += this.pixelConvertionForGrid)
            {
                Point startPoint = new Point(0, i);
                Point endPoint = new Point(this.width, i);

                graphic.DrawLine(gridPen, startPoint, endPoint);

            }
        }

        /*public void DrawWallBeams(Graphics graphic)
        {
            throw new NotImplementedException();
        }*/

        private void DrawY(Graphics graphic)
        {
            for (int i = this.pixelConvertionForGrid; i < this.width; i += this.pixelConvertionForGrid)
            {

                Point startPoint = new Point(i, 0);
                Point endPoint = new Point(i, this.height);

                graphic.DrawLine(gridPen, startPoint, endPoint);
            }
        }

        //Creo que deberíamos fijarnos si realmente es necesario hacer el redondeo antes de llevarlo a horizontal o vertical
        public Wall FixWalls(Point startWall, Point endWall)
        {
            Point startFixedWall = new Point(
                ((int)Math.Round((double)startWall.X / pixelConvertionForGrid)) * this.pixelConvertionForGrid,
                ((int)Math.Round((double)startWall.Y / pixelConvertionForGrid)) * this.pixelConvertionForGrid
            );

            Point endFixedWall = new Point(
                 ((int)Math.Round((double)endWall.X / pixelConvertionForGrid)) * this.pixelConvertionForGrid,
                 ((int)Math.Round((double)endWall.Y / pixelConvertionForGrid)) * this.pixelConvertionForGrid
            );

            var variationOnX = Math.Abs(startFixedWall.X - endFixedWall.X);
            var variationOnY = Math.Abs(startFixedWall.Y - endFixedWall.Y);

            if (variationOnY / variationOnX < 1)
            {
                endFixedWall.Y = startFixedWall.Y;
            }
            else
            {
                endFixedWall.X = startFixedWall.X;
            }

            return new Wall()
            {
                startPoint = startFixedWall,
                endPoint = endFixedWall
            };
        }

    }

}
