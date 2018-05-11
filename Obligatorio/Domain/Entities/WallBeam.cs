using System;
using System.Collections.Generic;
using System.Drawing;

namespace Domain.Entities
{
    public class WallBeam : Drawable
    {
        public Point UbicationPoint { get; set; }
        public List<Wall> AssociatedWalls;

        public override void Draw(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
