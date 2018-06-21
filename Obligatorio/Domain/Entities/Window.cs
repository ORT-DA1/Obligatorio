using Domain.Logic;
using Domain.Repositories;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace Domain.Entities
{
    [Table(name: "Windows")]
    public class Window : Element
    {
        #region PK and FK
        public int WindowId { get; set; }
        public virtual Grid Grid { get; set; }
        public virtual PriceAndCost PriceAndCost { get; set; }
        #endregion

        public Domain.Entities.Point StartPoint { get; set; }
        public Domain.Entities.Point EndPoint;
        public string sense;
        public float width { get; set; }
        public float high { get; set; }
        public static float MINIMUM_WIDTH = 0.8f;
        public static int MINIMUM_WIDTH_IN_PIXELS = 10;
        public static float MAXIMUM_WIDTH = 3.00f;
        public static float MAXIMUM_HIGH = 1.20f;
        public SolidBrush blueBrush = new SolidBrush(Color.Blue);
        public PriceAndCostHandler priceAndCostHandler;
        public GridRepository gridRepository;

        #region Constructors
        public Window() { }
        
        public Window(Point startPoint, Point endPoint, string sense)
        {
            this.sense = sense;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.width = 0.80f;
            this.high = 1.00f;


        }

        public Window(Point startPoint, Point endPoint, string sense, float width, float high, string name)
        {
            this.gridRepository = new GridRepository();
            this.priceAndCostHandler = new PriceAndCostHandler(gridRepository);
            this.blueBrush = new SolidBrush(Color.Blue);
            this.width = width;
            this.high = high;
            this.name = name;
            this.sense = sense;
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
        }

        #endregion

        public override void ModifyCostAndPrice(int cost, int price)
        {
            priceAndCostHandler.WindowModifyPriceCost(cost, price);
        }
        public override void Draw(Graphics graphic)
        {
            if (sense.Equals("vertical")) {
               
                graphic.FillRectangle(blueBrush, StartPoint.X- (MINIMUM_WIDTH_IN_PIXELS* 4/20), StartPoint.Y- (MINIMUM_WIDTH_IN_PIXELS * 10 / 20), 6, MINIMUM_WIDTH_IN_PIXELS/width);
            }
            else{
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
