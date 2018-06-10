using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Domain.TypesGrid
{
    public class WithoutVisualGrid : GridStrategy
    {
        private Pen gridPen;
        public override void DrawGrid(Graphics graphic, int height, int width)
        {
            this.gridPen = new Pen(Color.White, 3);
            this.DrawX(graphic, height, width);
            this.DrawY(graphic, height, width);
        }

        public override void DrawX(Graphics graphic, int height, int width)
        {
            for (int i = Grid.PixelConvertor; i < height; i += Grid.PixelConvertor)
            {
                Point startPoint = new Point(0, i);
                Point endPoint = new Point(width, i);
                graphic.DrawLine(gridPen, startPoint, endPoint);
            }
        }

        public override void DrawY(Graphics graphic, int height, int width)
        {
            for (int i = Grid.PixelConvertor; i < width; i += Grid.PixelConvertor)
            {
                Point startPoint = new Point(i, 0);
                Point endPoint = new Point(i, height);
                graphic.DrawLine(gridPen, startPoint, endPoint);
            }
        }
    }
}
