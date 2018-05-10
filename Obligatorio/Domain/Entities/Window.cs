using System;
using System.Drawing;

namespace Domain.Entities
{
    public class Window : Drawable
    {
        public Point point { get; set; }

        public override void Draw(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
