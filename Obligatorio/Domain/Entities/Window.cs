using System;
using System.Drawing;

namespace Domain.Entities
{
    public class Window : Element
    {
        public Point StartPoint;
        public Point EndPoint;
        public string sense;
        public float width = 0.80f;
        public float high = 1.00f;
        public static float MINIMUM_WIDTH = 0.8f;
        public static int MINIMUM_WIDTH_IN_PIXELS = 10;
        public static float MAXIMUM_WIDTH = 3.00f;
        public static float MAXIMUM_HIGH = 1.20f;

        public static Tuple<int, int> CostPriceWindow = new Tuple<int, int>(50, 75);

        public Window()
        {
        }

        public override void ModifyCostAndPrice(int Cost, int Price)
        {
            CostPriceWindow = new Tuple<int, int>(Cost, Price);
        }

        public Window(Point startPoint, Point endPoint, string sense)
        {
            this.sense = sense;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public Window(Point startPoint, Point endPoint, string sense, float width, float high, string name)
        {
            this.width = width;
            this.high = high;
            this.name = name;
            this.sense = sense;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        public override void Draw(Graphics graphic)
        {
            if (sense.Equals("vertical")) {
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                graphic.FillRectangle(blueBrush, StartPoint.X- (MINIMUM_WIDTH_IN_PIXELS* 4/20), StartPoint.Y- (MINIMUM_WIDTH_IN_PIXELS * 10 / 20), 6, MINIMUM_WIDTH_IN_PIXELS/width);
            }
            else{
                SolidBrush blueBrush = new SolidBrush(Color.Blue);
                graphic.FillRectangle(blueBrush, StartPoint.X- (MINIMUM_WIDTH_IN_PIXELS * 10 / 20), StartPoint.Y- (MINIMUM_WIDTH_IN_PIXELS * 4 / 20), MINIMUM_WIDTH_IN_PIXELS/width, 6);
            }
        }

        public override bool Equals(object windowObject)
        {
            bool isEqual = false;
            if (windowObject != null && this.GetType().Equals(windowObject.GetType()))
            {
                Window window = (Window)windowObject;
                if ((this.StartPoint.Equals(window.StartPoint)) && this.name.Equals(window.name))
                {
                    isEqual = true;
                }

            }
            return isEqual;
        }

    }
}
