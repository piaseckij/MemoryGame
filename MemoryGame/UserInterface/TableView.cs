using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Models;

namespace MemoryGame.UserInterface
{
    public static class TableView
    {
        public static void ShowBoard(Boards board)
        {
            for (int i = 0; i < board.Board.Count; i++)
            {
                Console.Write(board.Board[i].Text+" ");
                if (i==(board.Board.Count-1)/2)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
