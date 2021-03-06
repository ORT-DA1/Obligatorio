﻿using Domain.Logic;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "DecorativeColumns")]
    public class DecorativeColumn : Element
    {
        #region PK and FK
        public int DecorativeColumnId { get; set; }
        public virtual Grid Grid { get; set; }
        public virtual PriceAndCost PriceAndCost { get; set; }
        #endregion

        public Point UbicationPoint { get; set; }
        private SolidBrush wallBeamBrush = new SolidBrush(Color.Gold);
        public float width { get; set; }
        public static float MINIMUM_WIDTH = 0.85f;
        public static int MINIMUM_WIDTH_IN_PIXELS = 8;

        PriceAndCostHandler priceAndCostHandler;
        public GridRepository gridRepository;
        #region Constructors

        public DecorativeColumn() { }

        public DecorativeColumn(Point ubicationPoint)
        {
            this.gridRepository = new GridRepository();
            this.priceAndCostHandler = new PriceAndCostHandler(gridRepository);
            this.UbicationPoint = ubicationPoint;
            this.wallBeamBrush = new SolidBrush(Color.Gold);
            this.width = 0.50f;
        }

        #endregion

        public override void ModifyCostAndPrice(int cost, int price)
        {
            priceAndCostHandler.DecorativeColumnModifyPriceCost(cost, price);
        }

        public override void Draw(Graphics graphic)
        {
            Rectangle rectangle = new Rectangle(this.UbicationPoint.X - 5, this.UbicationPoint.Y - 5, MINIMUM_WIDTH_IN_PIXELS, MINIMUM_WIDTH_IN_PIXELS);
            float startAngle = 0;
            float sweepAngle = 360;
            graphic.FillPie(wallBeamBrush, rectangle, startAngle, sweepAngle);
        }

        public override bool Equals(object decorativeColumnObject)
        {
            bool isEqual = false;
            if (decorativeColumnObject != null && this.GetType().Equals(decorativeColumnObject.GetType()))
            {
                DecorativeColumn decorativeColumn = (DecorativeColumn)decorativeColumnObject;
                if (this.UbicationPoint.Equals(decorativeColumn.UbicationPoint))
                {
                    isEqual = true;
                }
            }
            return isEqual;
        }
    }
}
