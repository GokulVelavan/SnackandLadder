using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackandLadder
{
    class Program
    {
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;


        static void Main(string[] args)
        {
            int POSITION = 0;
            bool PLAYER1 = true;
            bool PLAYER2 = false;
            int DICE = 0;
            int PLAYER1_COUNT = 0;
            int PLAYER2_COUNT = 0;

            int DICE_COUNT = 0;
            int OPTION = 0;

            while (PLAYER1_COUNT < 100 && PLAYER2_COUNT<100)
            {
                Random random = new Random();
                DICE = random.Next(0, 7);
                DICE_COUNT++;
                OPTION = random.Next(0, 3);
                if(PLAYER1)
                {

                Console.WriteLine("THE DICE POSITION OF PLAYER 1:{0}",PLAYER1_COUNT );
                }
                else
                {
                    Console.WriteLine("THE DICE POSITION OF PLAYER 2:{0}", PLAYER2_COUNT);

                }
                Console.WriteLine("THE DICE  IS:{0}", DICE);

                switch (OPTION)
                {
                    case LADDER:
                        Console.WriteLine("THIS IS LADDER ");
                        if (PLAYER1)
                        {
                            if ((PLAYER1_COUNT + DICE) <= 100)
                            {
                                PLAYER1_COUNT += DICE;

                            }
                        }
                        else
                        {
                            if ((PLAYER2_COUNT + DICE) <= 100)
                            {
                                PLAYER2_COUNT += DICE;

                            }
                        }
                        break;
                    case SNAKE:
                        Console.WriteLine("THIS IS SNACK");
                        if (PLAYER1)
                        {
                                PLAYER1_COUNT -= DICE;
                            PLAYER1 = false;
                            PLAYER2 = true;
                        }
                        else
                        {

                            PLAYER2_COUNT -= DICE;
                            PLAYER1 = true;
                            PLAYER2 = false;
                        }
                        break;
                    default:
                        Console.WriteLine("YOU CANT PLAY NOW");
                        if (PLAYER1)
                        {
                            PLAYER1 = false;
                            PLAYER2 = true;
                        }
                        else
                        {
                            PLAYER1 = true;
                            PLAYER2 = false;
                        }
                        break;
                }
                if (PLAYER1_COUNT < 0)
                {
                    PLAYER1_COUNT = 0;
                }
                if(PLAYER2_COUNT<0)
                {
                    PLAYER2_COUNT = 0;
                }
            }
            if(PLAYER1_COUNT==100)
            {
                Console.WriteLine("HURRAY PLAYER 1 WINS");
            }
            else
            {
                Console.WriteLine("HURRAY PLAYER 2 WINS");

            }
            Console.ReadLine();
        }
    }
}