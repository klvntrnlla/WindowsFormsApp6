using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    //Inheritance
    public class TicTacToeBoard : GameBoard
    {
        public TicTacToeBoard(char[,] board) : base(board)
        {
        }

        public override char DetermineWinner() //Method Overriding
        {
            for (int k = 0; k < 3; k++)
            {
                if (board[k, 0] == board[k, 1] && board[k, 1] == board[k, 2] && board[k, 0] != ' ')
                {
                    return board[k, 0];
                }
            }

            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != ' ')
                {
                    return board[0, j];
                }
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != ' ')
            {
                return board[0, 0];
            }
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != ' ')
            {
                return board[0, 2];
            }

            return ' ';
        }
    }
}