using System;
using System.Collections.Generic;
using System.Text;

namespace Module5
{
    public class Hero
    {
        // Setting X-location, Y-location and lifes' quantity of Hero.
        public int xPoint;
        public int yPoint;
        public int liveQuantity;

        public Hero(int xPoint, int yPoint, int liveQuantity)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
            this.liveQuantity = liveQuantity;
        }
    }
}