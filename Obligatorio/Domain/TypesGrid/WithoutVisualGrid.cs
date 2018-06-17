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
                Entities.Point startPoint = new Entities.Point(0, i);
                Entities.Point endPoint = new Entities.Point(width, i);
                graphic.DrawLine(gridPen, new System.Drawing.Point(startPoint.X,startPoint.Y)
                    , new System.Drawing.Point(endPoint.X,endPoint.Y));
            }
        }

        public override void DrawY(Graphics graphic, int height, int width)
        {
            for (int i = Grid.PixelConvertor; i < width; i += Grid.PixelConvertor)
            {
                Entities.Point startPoint = new Entities.Point(i, 0);
                Entities.Point endPoint = new Entities.Point(i, height);
                graphic.DrawLine(gridPen, new System.Drawing.Point(startPoint.X,startPoint.Y)
                    , new System.Drawing.Point(endPoint.X,endPoint.Y));
            }
        }
    }
}
