using System;
using System.Security.Cryptography.X509Certificates;

namespace SnakeLadderGame
{
    class Program
    {
        public const int START_POSITION = 0, END_POSITION = 100;
        public static Random random = new Random();
        public static int DiceRoll()
        {
            return random.Next(1, 7);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Online Snake and Ladder Game");
            int currentPosition = START_POSITION;
            int diceValue = DiceRoll();
        }
    }
}