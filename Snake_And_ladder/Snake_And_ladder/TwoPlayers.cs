using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_And_ladder
{
     class TwoPlayers
    {
        public const int WIN = 100;
       
        public void Players()
        {

           UC7_TWOPLAYERS player1 = new UC7_TWOPLAYERS();
            UC7_TWOPLAYERS player2 = new UC7_TWOPLAYERS();
            Console.WriteLine("The starting position of player is: " + player1.Position + "\n");

            while (player1.Position < WIN || player2.Position < WIN)
            {
                Console.WriteLine("Player 1:");
                player1.CheckPosition();
                if ((player1.option == 1) && (player1.Position < WIN))
                {
                    Console.WriteLine("Player 1:");
                    player1.CheckPosition();
                }
                if (player1.Position > WIN)
                    player1.Position -= player1.Die;

                if (player1.Position == WIN)
                {
                    Console.WriteLine("Player 1 won the game");
                    break;
                }


                Console.WriteLine("Player 2:");
                player2.CheckPosition();
                if (player2.option == 1 && player2.Position < WIN)
                {
                    Console.WriteLine("Player 2:");
                    player2.CheckPosition();
                }
                if (player2.Position > WIN)
                    player2.Position -= player2.Die;

                if (player2.Position == WIN)
                {
                    Console.WriteLine("Player 2 won the game");
                    break;
                }
            }

        }
    }
}

