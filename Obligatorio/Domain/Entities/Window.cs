using System;
using System.Drawing;

namespace Domain.Entities
{
    public class Window : Element
    {
        private Point ubicationPoint;

        public Window()
        {
        }

        public Window(Point ubicationPoint)
        {
            this.ubicationPoint = ubicationPoint;
        }

        public override void Draw(Graphics graphic)
        {
            throw new NotImplementedException();
        }
    }
}
