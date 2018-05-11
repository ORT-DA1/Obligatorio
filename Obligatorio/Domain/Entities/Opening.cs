using System;
using System.Drawing;

namespace Domain.Entities
{
    public class Opening : Drawable
    {
        public Point UbicationPoint { get; set; }
        
        public override void Draw(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
