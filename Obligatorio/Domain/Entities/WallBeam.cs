using System;
using System.Drawing;

namespace Domain.Entities
{
    public class WallBeam : Element
    {
        public Point UbicationPoint { get; set; }
        private SolidBrush wallBeamBrush;

        public Tuple<int, int> CostPriceWallBeam { get; set; }

        public WallBeam(Point ubicationPoint)
        {
            this.CostPriceWallBeam = new Tuple<int, int>(50, 100);
            this.UbicationPoint = ubicationPoint;
            this.wallBeamBrush = new SolidBrush(Color.Red);
        }

        public void ModifyCostAndPrice(int Cost, int Price)
        {
            this.CostPriceWallBeam = new Tuple<int, int>(Cost, Price);
        }

        public override void Draw(Graphics graphic)
        {
            Rectangle rectangle = new Rectangle(this.UbicationPoint.X-5, this.UbicationPoint.Y-5, 10, 10);
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
