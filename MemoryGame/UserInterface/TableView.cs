using MemoryGame.Models;

namespace MemoryGame.UserInterface;

public static class TableView
{
    public static void ShowBoard(Boards board)
    {
        List<Word> _board = new();

        _board = board.Board;
        Console.Write("  ");
        for (var j = 0; j < _board.Count / 2; j++) Console.Write((char)('A' + j) + " ");

        Console.WriteLine();
        Console.Write("1 ");
        for (var i = 0; i < _board.Count; i++)
        {
            if (_board[i].IsGuessed||_board[i].IsSelected)
                Console.Write(_board[i].Text + " ");
            else
                Console.Write("X" + " ");

            if (i == (_board.Count - 1) / 2)
            {
                Console.WriteLine();
                Console.Write("2 ");
            }
        }
    }
}