using MemoryGame.Models;

namespace MemoryGame.GameLogic;

public static class Select
{
    public static Word SelectField(UserSelection userSelections, Boards board)
    {
        

        if (!board.Board[userSelections.Line][userSelections.Column - 1].IsGuessed)
        {
            board.Board[userSelections.Line][userSelections.Column - 1].IsSelected =
                !board.Board[userSelections.Line][userSelections.Column - 1].IsSelected;

        }

        return board.Board[userSelections.Line][userSelections.Column - 1];
    }
}