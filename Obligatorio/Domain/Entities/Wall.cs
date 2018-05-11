using System;
using System.Collections.Generic;
using System.Drawing;

namespace Domain.Entities
{
    public class Wall : Drawable
    {

        public Point startUbicationPoint { get; set; }
        public Point endUbicationPoint { get; set; }

        public override void Draw(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
