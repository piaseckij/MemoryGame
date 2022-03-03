using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemoryGame.Models;

namespace MemoryGame.GameLogic
{
    public class Select
    {

        public static void SelectField(UserSelection selection, Boards board)
        {
            
            if (selection.Line == 'A')
            {
                board.Board[0][selection.Column-1].IsSelected=!board.Board[0][selection.Column-1].IsSelected;
            }

            if (selection.Line == 'B')
            {
                board.Board[1][selection.Column - 1].IsSelected=!board.Board[1][selection.Column - 1].IsSelected;

            }
        }
    }
}
