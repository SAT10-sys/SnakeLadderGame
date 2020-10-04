using System;
using System.Security.Cryptography.X509Certificates;

namespace SnakeLadderGame
{
    class Program
    {
        public const int START_POSITION = 0, END_POSITION = 100;
        public const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        public static Random random = new Random();
        public static int DiceRoll()
        {
            return random.Next(1, 7);
        }
        public static int Movement(int diceValue)
        {
            int checkOption = random.Next(0, 3);
            int stepsMoved = 0;
            switch (checkOption)
            {
                case LADDER:
                    stepsMoved = diceValue;
                    break;
                case SNAKE:
                    stepsMoved = -diceValue;
                    break;
                default:
                    break;
            }
            return stepsMoved;
        }
        static void Main(string[] args)
        {
            int nextPosition;
            Console.WriteLine(" Welcome to Online Snake and Ladder Game");
            int currentPosition = START_POSITION;
            while (currentPosition < END_POSITION)
            {
                int diceValue = DiceRoll();
                int stepsToMove = Movement(diceValue);
                if (currentPosition + stepsToMove > END_POSITION)
                    nextPosition = currentPosition;
                else
                    nextPosition = currentPosition + stepsToMove;
                if (nextPosition < START_POSITION)
                    currentPosition = START_POSITION;
                else
                    currentPosition = nextPosition;
            }
            Console.WriteLine(" Final Position is: " + currentPosition);
        }
    }
}