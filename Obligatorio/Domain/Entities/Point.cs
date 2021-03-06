﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table(name: "Points")]
    public class Point
    {
        #region PK and FK
        public int PointId { get; set; }
        #endregion
        public int X { get; set; }
        public int Y { get; set; }

        #region Constructors

        public Point() { }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        #endregion

        public override bool Equals(object pointObject)
        {
            bool isEqual = false;
            if (pointObject != null && this.GetType().Equals(pointObject.GetType()))
            {
                Point point = (Point)pointObject;
                if (this.X.Equals(point.X) && this.Y.Equals(point.Y))
                {
                    isEqual = true;
                }

            }
            return isEqual;
        }
    }
}
