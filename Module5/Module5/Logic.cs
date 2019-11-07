using System;
using System.Collections.Generic;
using System.Text;

namespace Module5
{
    class Logic
    {
        // Chanding Hero's position using move buttons.
        public static void Step(Hero hero)
        {
            string moveHero = Console.ReadKey().Key.ToString();
            switch (moveHero)
            {
                case "UpArrow":
                    if (hero.xPoint > 1)
                    {
                        --hero.xPoint;
                    }
                    break;
                case "RightArrow":
                    if (hero.yPoint < Settings.FIELD_SIDE)
                    {
                        ++hero.yPoint;
                    }
                    break;
                case "DownArrow":
                    if (hero.xPoint < Settings.FIELD_SIDE)
                    {
                        ++hero.xPoint;
                    }
                    break;
                case "LeftArrow":
                    if (hero.yPoint > 1)
                    {
                        --hero.yPoint;
                    }
                    break;
            }
        }

        // Loosing life and deactivate tpap if Hero get in the trap.
        public static void GetDamage(Hero hero, List<Traps> traps)
        {
            foreach (var item in traps)
            {
                if ((hero.xPoint == item.xPoint) && (hero.yPoint == item.yPoint) && (item.status))
                {
                    --hero.liveQuantity;
                    item.status = false;
                }
            }
        }

        // Method to check if the Hero get to finish point.
        public static bool CheckWin(Hero hero)
        {
            if ((hero.xPoint == Settings.X_FINISH_HERO) && (hero.yPoint == Settings.Y_FINISH_HERO))
            {
                return true;
            }
            return false;
        }

        // Method to check if the Hero lost all his lifes.
        public static bool CheckLose(Hero hero)
        {
            return hero.liveQuantity == 0;
        }

        // Mothod for restart or close game according to pessed button.
        public static bool CheckContinueOrClose()
        {
            string answerKey = Console.ReadKey().Key.ToString();
            switch (answerKey)
            {
                case "Y":
                    {
                        return true;
                    }
                case "N":
                    {
                        return false;
                    }
                default:
                    {
                        Console.WriteLine("\nIncorrect key.");
                        CheckContinueOrClose();
                        return false;
                    }
            }
        }
    }
}