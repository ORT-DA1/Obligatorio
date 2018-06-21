using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Domain.Entities
{
    [Table(name: "Doors")]
    public class Door : Element
    {
        #region PK and FK
        public int DoorId { get; set; }
        public virtual Grid Grid { get; set; }
        #endregion

        public Domain.Entities.Point StartPoint { get; set; }
        public Domain.Entities.Point EndPoint;
        public int direction;
        public string sense;
        public float width { get; set; }
        public float high { get; set; }
        public static float MINIMUM_WIDTH = 0.85f;
        public static int MINIMUM_WIDTH_IN_PIXELS = 15;
        public static float MAXIMUM_WIDTH = 3.00f;
        public static float MAXIMUM_HIGH = 2.00f;
        public SolidBrush blueBrush = new SolidBrush(Color.Blue);

        public static Tuple<int, int> CostPriceDoor = new Tuple<int, int>(50, 100);

        #region Constructors
        public Door()
        {
        }

        public Door(Point startPoint, Point endPoint, string sense)
        {
            this.blueBrush = new SolidBrush(Color.Blue);
            this.sense = sense;
            this.direction = 0;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;

            this.width = 0.85f;
            this.high = 2.20f;
        }

        public Door(Point startPoint, Point endPoint, string sense, float width, float high, string name)
        {
            this.width = width;
            this.high = high;
            this.name = name;
            this.sense = sense;
            this.direction = 0;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;

        }
        #endregion
        public override void ModifyCostAndPrice(int Cost, int Price)
        {
            CostPriceDoor = new Tuple<int, int>(Cost, Price);
        }

        public override void Draw(Graphics graphic)
        {
            float angle = this.startAngle(StartPoint, EndPoint);
            Point fixedPoint = fixDoorPoint(StartPoint);
            graphic.FillPie(blueBrush, fixedPoint.X, fixedPoint.Y,
                width * MINIMUM_WIDTH_IN_PIXELS / MINIMUM_WIDTH,
                width * MINIMUM_WIDTH_IN_PIXELS / MINIMUM_WIDTH,
                angle, 90f);
        }

        private Point fixDoorPoint(Point startPoint)
        {
            if (sense.Equals("vertical"))
            {
                if (this.direction.Equals(1))
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 16 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 22 / 30)));
                }
                else if (this.direction.Equals(2))
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 16 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 8 / 30)));
                }
                else if (this.direction.Equals(3))
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 12 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 8 / 30)));
                }
                else
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 12 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 22 / 30)));
                }
            }
            else
            {
                if (this.direction.Equals(1))
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 20 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 16 / 30)));
                }
                else if (this.direction.Equals(2))
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 20 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 12 / 30)));
                }
                else if (this.direction.Equals(3))
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 8 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 12 / 30)));
                }
                else
                {
                    return (new Point(startPoint.X - (MINIMUM_WIDTH_IN_PIXELS * 8 / 30), startPoint.Y - (MINIMUM_WIDTH_IN_PIXELS * 16 / 30)));
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
                if ((this.StartPoint.Equals(door.StartPoint)) && this.name.Equals(door.name))
                {
                    isEqual = true;
                }

            }
            return isEqual;
        }
    }
}
