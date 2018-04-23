using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Door
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public override string ToString()
        {
            string format = "x1: {0}, y1:{1}";
            return String.Format(format, this.X1, this.Y1);
        }
    }
}
