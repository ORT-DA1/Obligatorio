using System.Drawing;

namespace Domain.Entities
{
    public class Door : Element
    {
        private Point ubicationPoint;

        public Door()
        {
        }

        public Door(Point ubicationPoint)
        {
            this.ubicationPoint = ubicationPoint;
        }

        public override void Draw(Graphics graphic)
        {
            
        }
    }
}
