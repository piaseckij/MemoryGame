using MemoryGame.Models;

namespace MemoryGame.GameLogic;

public static class WinChecking
{
    public static bool CheckWin(Boards board)
    {
        return board.Board.All(row => row.All(field => field.IsGuessed));
    }
}