using System.Drawing;

namespace Domain.Entities
{
    public class WallBeam : Element
    {
        public Point UbicationPoint { get; set; }
        private SolidBrush wallBeamBrush;

        public WallBeam(Point ubicationPoint)
        {
            this.UbicationPoint = ubicationPoint;
            this.wallBeamBrush = new SolidBrush(Color.Red);
        }

        public override void Draw(Graphics graphic)
        {
            Rectangle rectangle = new Rectangle(this.UbicationPoint.X, this.UbicationPoint.Y, 10, 10);
            float startAngle = 0;
            float sweepAngle = 360;
            graphic.FillPie(wallBeamBrush, rectangle, startAngle, sweepAngle);
        }

        public override bool Equals(object wallBeamObject)
        {
            bool isEqual = false;
            if (wallBeamObject != null && this.GetType().Equals(wallBeamObject.GetType()))
            {
                WallBeam wallBeam = (WallBeam)wallBeamObject;
                if (this.UbicationPoint.Equals(wallBeam.UbicationPoint))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }
    }
}
