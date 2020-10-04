using Snake_Ladder_Game;
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
            Person player1 = new Person(" PLAYER ONE ");
            Person player2 = new Person(" PLAYER TWO ");
            Person currentPlayer = player1;
            bool isGameFinished = false;
            while(!isGameFinished)
            {
                int diceValue = DiceRoll();
                currentPlayer.noOfMoves++;
                int stepsToMove = Movement(diceValue);
                if (currentPlayer.currentPosition + stepsToMove == END_POSITION)
                {
                    currentPlayer.nextPosition = END_POSITION;
                    isGameFinished = true;
                }
                else if (currentPlayer.currentPosition + stepsToMove > END_POSITION)
                {
                    currentPlayer.nextPosition = currentPlayer.currentPosition;
                }
                else
                    currentPlayer.nextPosition = currentPlayer.currentPosition + stepsToMove;
                if (currentPlayer.nextPosition < START_POSITION)
                    currentPlayer.currentPosition = START_POSITION;
                else
                    currentPlayer.currentPosition = currentPlayer.nextPosition;
                //displaying current player position after every roll of the dice
                Console.WriteLine(currentPlayer.Name + "'s position after dice roll " + currentPlayer.noOfMoves + " is: " + currentPlayer.currentPosition);
                if (stepsToMove > 0 && !isGameFinished)
                    continue; // continue Move if ladder occurs and game is not finished
                else if (!isGameFinished)
                    currentPlayer = (currentPlayer == player1) ? player2 : player1;
            }
            Console.WriteLine(" The Game has finished ");
            Console.WriteLine(" The Winner is: " + currentPlayer.Name + " with total number of throws is: " + currentPlayer.noOfMoves);
        }
    }
}