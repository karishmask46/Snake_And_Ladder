using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_ladder
{
    internal class UC5_WinningPostion100
    {
        public const int Ladder = 1, Snake = 2;
        public void CheckPosition()
        {
            int Position = 0;
            Console.WriteLine("Start the postion from 0 : " + Position);
            for ( ;Position < 100;)
            {
                Random random1 = new Random();
                int Die = random1.Next(1, 7);
                Console.WriteLine("The die get the number is : " + Die);
                Random random2 = new Random();
                int option = random2.Next(0, 3);
                switch (option)
                {
                    case Ladder:
                        Position += Die;
                        Console.WriteLine("The Player got the Ladder");
                        if (Position > 100)
                        {
                            Position -= Die;
                        }
                        break;
                    case Snake:
                        Position -= Die;
                        if (Position < 0)
                        {
                            Console.WriteLine("The player bitten by a snake");
                            Position = 0;
                        }
                        break;
                    default:
                        Console.WriteLine($"No play");
                        break;
                }
            }
            Console.WriteLine("The player position is : " + Position);
            
        }
    }
}
    

