using System;
using System.Collections.Generic;
using System.Text;

namespace Module5
{
    class Traps
    {
        // Setting X-location, Y-location and activated state of the trap.
        public int xPoint;
        public int yPoint;
        public bool status;

        private Traps(int xPoint, int yPoint, bool status = true)
        {
            this.xPoint = xPoint;
            this.yPoint = yPoint;
            this.status = status;
        }

        // Creating list of trap's location. 
        public static List<Traps> CreateTraps(Hero hero)
        {
            List<Traps> traps = new List<Traps>();
            int xPositionTrap;
            int yPositionTrap;
            Random trapsPosition = new Random();
            for (int i = 0; i < Settings.TRAPS_QUANTITY; i++)
            {
                do
                {
                    xPositionTrap = trapsPosition.Next(1, Settings.FIELD_SIDE);
                    yPositionTrap = trapsPosition.Next(1, Settings.FIELD_SIDE);
                }
                while (!IsValidTrapPosition(xPositionTrap, yPositionTrap, hero, traps));
                traps.Add(new Traps(xPositionTrap, yPositionTrap));
            }
            return traps;
        }

        // Checking if trap's location doesn't match with Hero's location, finish point or others traps' locations.
        private static bool IsValidTrapPosition(int xPosition, int yPosition, Hero hero, List<Traps> traps)
        {
            if ((xPosition == hero.xPoint) && (yPosition == hero.yPoint))
            {
                return false;
            }
            if ((xPosition == Settings.X_FINISH_HERO) && (yPosition == Settings.Y_FINISH_HERO))
            {
                return false;
            }
            foreach (var item in traps)
            {
                if ((xPosition == item.xPoint) && (yPosition == item.yPoint))
                {
                    return false;
                }
            }
            return true;
        }
    }
}