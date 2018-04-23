using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Line
    {
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int Y1 { get; set; }
        public int Y2 { get; set; }

        public override string ToString()
        {
            string format = "x1: {0}, y1:{1} , x2: {2}, y2:{3}";
            return String.Format(format, this.X1, this.Y1, this.X2, this.Y2);
        }
    }
}
