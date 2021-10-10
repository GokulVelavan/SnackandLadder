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
            int PLAYER = 1;
            int DICE = 0;
            int COUNT = 0;
            int OPTION = 0;

            while (COUNT < 100)
            {
                Random random = new Random();
                DICE = random.Next(0, 7);
                OPTION = random.Next(0, 3);
                Console.WriteLine("THE STARTING POSITION IS:{0}", COUNT);
                Console.WriteLine("THE DICE IS:{0}", DICE);

                switch (OPTION)
                {
                    case LADDER:
                        Console.WriteLine("THIS IS LADDER ");
                        COUNT += DICE;
                        break;
                    case SNAKE:
                        Console.WriteLine("THIS IS SNACK");
                        COUNT -= DICE;
                        break;
                    default:
                        Console.WriteLine("YOU CANT PLAY NOW");
                        break;
                }
                if(COUNT<0)
                {
                    COUNT = 0;
                }
            }
            Console.WriteLine("count :{0}", COUNT);
            Console.ReadLine();
        }
    }
}