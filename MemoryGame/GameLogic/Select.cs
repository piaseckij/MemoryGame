using MemoryGame.Models;

namespace MemoryGame.GameLogic;

public static class Select
{
    public static Word SelectField(UserSelection selection, Boards board)
    {
        switch (selection.Line)
        {
            case 'A':
            {
                if (!board.Board[0][selection.Column - 1].IsGuessed)
                    board.Board[0][selection.Column - 1].IsSelected = !board.Board[0][selection.Column - 1].IsSelected;

                return board.Board[0][selection.Column - 1];
            }
            case 'B':
            {
                if (!board.Board[1][selection.Column - 1].IsGuessed)
                    board.Board[1][selection.Column - 1].IsSelected = !board.Board[1][selection.Column - 1].IsSelected;
                return board.Board[1][selection.Column - 1];
            }
            default:
                return null;
        }
    }
}