using System;
using System.Drawing;

namespace Domain.Entities
{
    public class Door : Element
    {
        public Point StartPoint;
        public Point EndPoint;
        public int direction;
        public string sense;

        public Tuple<int, int> CostPriceDoor { get; set; }

        public Door()
        {
        }

        public Door(Point startPoint, Point endPoint, string sense)
        {
            this.CostPriceDoor = new Tuple<int, int>(50, 100);
            this.sense = sense;
            this.direction = 0;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public void ModifyCostAndPrice(int Cost, int Price)
        {
            this.CostPriceDoor = new Tuple<int, int>(Cost, Price); 
        }

        public override void Draw(Graphics graphic)
        {
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            float angle = this.startAngle(StartPoint, EndPoint);
            Point fixedPoint = fixDoorPoint(StartPoint);
            graphic.FillPie(blueBrush, fixedPoint.X, fixedPoint.Y, 30, 30, angle, 90f);
        }

        private Point fixDoorPoint(Point startPoint)
        {
            if (sense.Equals("vertical")) {
                if (this.direction.Equals(1))
                {
                    return (new Point(startPoint.X - 16, startPoint.Y - 22));
                }
                else if (this.direction.Equals(2))
                {
                    return (new Point(startPoint.X - 16, startPoint.Y - 8));
                }
                else if (this.direction.Equals(3))
                {
                    return (new Point(startPoint.X - 12, startPoint.Y - 8));
                }
                else
                {
                    return (new Point(startPoint.X - 12, startPoint.Y - 22));
                }
            }else
            {
                if (this.direction.Equals(1))
                {
                    return (new Point(startPoint.X - 20, startPoint.Y - 16));
                }
                else if (this.direction.Equals(2))
                {
                    return (new Point(startPoint.X - 20, startPoint.Y - 12));
                }
                else if (this.direction.Equals(3))
                {
                    return (new Point(startPoint.X - 8, startPoint.Y - 12));
                }
                else
                {
                    return (new Point(startPoint.X - 8, startPoint.Y - 16));
                }
            }
        }

        public float startAngle(Point startPoint, Point endPoint)
        {
            int x = endPoint.X - startPoint.X;
            int y = endPoint.Y - startPoint.Y;

            if (x > 0 && y > 0)
            {
                this.direction = 1;
                return 0f;
            }
            if (x > 0 && y <= 0)
            {
                this.direction = 2;
                return 270f;
            }
            if (x <= 0 && y <= 0)
            {
                this.direction = 3;
                return 180f;
            }
            if (x <= 0 && y > 0)
            {
                this.direction = 4;
                return 90f;
            }
            return 0f;
        }

        public override bool Equals(object doorObject)
        {
            bool isEqual = false;
            if (doorObject != null && this.GetType().Equals(doorObject.GetType()))
            {
                Door door = (Door)doorObject;
                if ((this.StartPoint.Equals(door.StartPoint)))
                {
                    isEqual = true;
                }

            }
            return isEqual;
        }
    }
}
