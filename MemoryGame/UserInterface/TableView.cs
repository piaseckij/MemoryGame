using MemoryGame.Models;
using MemoryGame.Models.Difficulties;

namespace MemoryGame.UserInterface;

public class TableView
{
    private readonly Boards _board;
    private readonly IDifficulty _difficulty;

    public TableView(Boards board, IDifficulty difficulty)
    {
        _board = board;
        _difficulty = difficulty;
    }

    public void ShowBoard()
    {
        var index = 0;
        Console.WriteLine("---------------------");
        Console.WriteLine($"Level: {_difficulty.Name}");
        Console.WriteLine($"Tries left: {_difficulty.Tries}");
        Console.WriteLine("---------------------\n");

        Console.Write("   ");
        for (var j = 0; j < _board.Board[0].Count; j++) Console.Write((string) $"{1 + j}             ");
        Console.WriteLine();
        foreach (var row in _board.Board)
        {
            Console.Write((char) ('A' + index) + "  ");
            foreach (var field in row)
                if (field.IsGuessed || field.IsSelected)
                {
                    var output = field.Text;
                    while (output.Length < 14) output = output + " ";
                    Console.Write(output);
                }
                else
                {
                    Console.Write("X" + "             ");
                }

            Console.WriteLine();
            index++;
        }
    }
}