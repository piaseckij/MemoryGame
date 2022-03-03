using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Models;

namespace MemoryGame.GameLogic
{
    public class WinChecking
    {
        public static bool CheckWin(Boards board)
        {
            foreach (var row in board.Board)
            {
                foreach (var field in row)
                {
                    if (field.IsGuessed == false)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
