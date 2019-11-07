using System;
using System.Collections.Generic;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                // Set Hero on the start position with 10 lifes.
                Hero hero = new Hero(Settings.X_START_HERO, Settings.Y_START_HERO, Settings.LIVES_QUANTITY);

                // Creating list of the traps' location.
                List<Traps> traps = Traps.CreateTraps(hero);

                // Continue game while getting final position or loosing lives.
                while (!Logic.CheckWin(hero) && !Logic.CheckLose(hero))
                {
                    Console.Clear();
                    Display.DislpayGameField(hero);
                    Logic.Step(hero);
                    Logic.GetDamage(hero, traps);
                    Console.Clear();
                    Display.DislpayGameField(hero);
                }

                // Writing final message and proposal to play one more game.
                var finalMessage = Logic.CheckWin(hero) ? "\nYou win." : "\nYou lose.";
                Console.WriteLine($"{finalMessage} One more game? Press \"Y\" - YES or \"N\" - NO");
               
            }
            while (Logic.CheckContinueOrClose());
        }
    }
}