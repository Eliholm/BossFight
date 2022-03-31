using System;
using System.Collections.Generic;

namespace BossFight
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Hero = new GameCharacter("Hero", 100, 20, 40);
            var Boss = new GameCharacter("Boss", 250, 0, 30, 10);

            while (Hero._health > 0 && Boss._health > 0)
            {
                Hero.Fight(Boss);
                Boss.Fight(Hero);
            }

            if (Hero._health > 0)
            {
                Console.WriteLine("Hero is the winner!");
            }
            else
            {
                Console.WriteLine("Boss is the winner!");
            }
        }
    }
}
