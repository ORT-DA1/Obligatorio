using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class GridStrategy
    {
        public abstract void DrawGrid(Graphics graphic, int height, int width);
        public abstract void DrawX(Graphics graphic, int height, int width);
        public abstract void DrawY(Graphics graphic, int height, int width);
    }
}
