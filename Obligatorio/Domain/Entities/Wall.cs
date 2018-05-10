using System;
using System.Collections.Generic;
using System.Drawing;

namespace Domain.Entities
{
    public class Wall : Drawable
    {

        public Point startPoint { get; set; }
        public Point endPoint { get; set; }
        public List<WallBeam> AssociatedWallBeams { get; set; }

        public override void Draw(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
