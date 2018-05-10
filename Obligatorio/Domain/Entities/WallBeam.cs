using System;
using System.Drawing;

namespace Domain.Entities
{
    public class WallBeam : Drawable
    {
        public Point Point { get; set; }
        public List<Wall> AssociatedWalls;

        public override void Draw(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
