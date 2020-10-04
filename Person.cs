using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_Ladder_Game
{
    class Person
    {
        public int currentPosition, nextPosition, noOfMoves;
        public string Name;
        public Person(string Name)
        {
            this.Name = Name;
            this.currentPosition = 0;
            this.nextPosition = 0;
            this.noOfMoves = 0;
        }
    }
}
