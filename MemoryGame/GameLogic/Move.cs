using MemoryGame.Models;
using MemoryGame.UserInterface;

namespace MemoryGame.GameLogic;

public static class Move
{
    public static List<Word> MakeMove(Boards board, List<UserSelection> userSelections)
    {
        var selectedWord1 = Select.SelectField(userSelections[0], board);
        var selectedWord2 = Select.SelectField(userSelections[1], board);

        List<Word> selectedWords = new()
        {
            selectedWord1,
            selectedWord2
        };
        return selectedWords;
    }
}