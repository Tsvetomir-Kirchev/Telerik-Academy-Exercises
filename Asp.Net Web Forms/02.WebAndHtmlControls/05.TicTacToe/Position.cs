using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05.TicTacToe
{
    public struct Position
    {
        public int X;
        public int Y;

        public Position(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}