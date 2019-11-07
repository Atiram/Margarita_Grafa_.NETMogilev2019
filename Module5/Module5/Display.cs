using System;
using System.Collections.Generic;
using System.Text;

namespace Module5
{
    class Display
    {
        public static void DislpayGameField(Hero hero)
        {
            for (int i = 0; i < Settings.FIELD_SIDE + Settings.BORDER_SIDE; i++)
            {
                for (int j = 0; j < Settings.FIELD_SIDE + Settings.BORDER_SIDE; j++)
                {
                    // Display borders.
                    if (((i == 0) || (i == Settings.FIELD_SIDE + 1)) || ((j == 0) || (j == Settings.FIELD_SIDE + 1)))
                    {
                        Console.Write("8");
                    }

                    // Display Hero.
                    else if (i == hero.xPoint && j == hero.yPoint)
                    {
                        Console.Write("H");
                    }

                    // Display finish point.
                    else if (i == Settings.X_FINISH_HERO && j == Settings.Y_FINISH_HERO)
                    {
                        Console.Write("F");
                    }

                    // Display empty spaces where are 10 invisiable traps.
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            // Display live's quantity.
            Console.WriteLine($"Lives: {hero.liveQuantity}");
            Console.WriteLine("\nUP - press UpArrow");
            Console.WriteLine("Down - press DownArrow");
            Console.WriteLine("Right - press RightArrow");
            Console.WriteLine("Left - press LeftArrow");
        }
    }
}