using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeladder
{
    internal class UC3
    {
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int snake = 2;
        public int position1 = 0;
        public int position2 = 0;
        public int die = 0;
        public int win = 100;
        public int totalcount = 0;
        public int diecountplayer = 0;


        public void checkoption()
        {
            Random random = new Random();
            while (position1 != win)
            {
            player:
                int option = random.Next(1, 7);
                Console.WriteLine(option);
                int check = random.Next(0, 3);
                Console.WriteLine(check);
                totalcount++;
                diecountplayer++;
                switch (check)
                {
                    case No_Play:
                        break;
                    case Ladder:
                        position1 += die;
                        if (position1 > win)
                        {
                            position1 += die;
                            break;
                        }
                        Console.WriteLine("ladder");
                        goto player;

                    default:
                        position1 -= die;
                        if (position1 < 0)
                        {
                            position1 = 0;
                        }
                        Console.WriteLine("snake");
                        break;
                }
                Console.WriteLine(totalcount);
                Console.WriteLine(diecountplayer);

            }

        }
    }
}
