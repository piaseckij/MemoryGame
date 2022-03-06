using MemoryGame.Models;

namespace MemoryGame.GameLogic;

public static class Move
{
    public static Word MakeMove(Boards board, UserSelection userSelections)
    {
        return Select.SelectField(userSelections, board);
    }
}