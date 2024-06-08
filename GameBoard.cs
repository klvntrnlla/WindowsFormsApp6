using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    public abstract class GameBoard //Abstract Method
    {
        protected char[,] board; //Protected Members

        protected GameBoard(char[,] board) //Protected Members
        {
            this.board = board;
        }

        public abstract char DetermineWinner(); //Abstract Method

        public bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}