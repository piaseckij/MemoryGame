using MemoryGame.Models;

namespace MemoryGame.UserInterface;

public static class TableView
{
    public static void ShowBoard(Boards board)
    {
        List<List<Word>> _board = new();

        _board = board.Board;

        foreach (var row in _board)
        {
            foreach (var field in row)
                if (field.IsGuessed || field.IsSelected)
                {
                    Console.Write(field.Text + " ");
                }
                else
                {
                    Console.Write("X" + " ");
                }

            Console.WriteLine();
        }
    }
}