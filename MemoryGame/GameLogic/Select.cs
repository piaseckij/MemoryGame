using MemoryGame.Models;

namespace MemoryGame.GameLogic;

public static class Select
{
    public static List<Word> SelectField(List<UserSelection> userSelections, Boards board)
    {
        var outputWords = new List<Word>();

        if (!board.Board[userSelections[0].Line][userSelections[0].Column-1].IsGuessed &&
            !board.Board[userSelections[1].Line][userSelections[1].Column-1].IsGuessed)
        {
            board.Board[userSelections[0].Line][userSelections[0].Column-1].IsSelected =
                !board.Board[userSelections[0].Line][userSelections[0].Column-1].IsSelected;

            board.Board[userSelections[1].Line][userSelections[1].Column-1].IsSelected =
                !board.Board[userSelections[1].Line][userSelections[1].Column-1].IsSelected;
        }
        outputWords.Add(board.Board[userSelections[0].Line][userSelections[0].Column-1]);
        outputWords.Add(board.Board[userSelections[1].Line][userSelections[1].Column-1]);

        return outputWords;
    }
}