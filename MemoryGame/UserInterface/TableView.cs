using System.Runtime.Serialization.Formatters;
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
        Console.WriteLine("---------------------");
        Console.WriteLine($"Level: {_difficulty.Name}");
        Console.WriteLine($"Tries left: {_difficulty.Tries}");
        Console.WriteLine("---------------------\n");

        foreach (var row in _board.Board)
        {
            foreach (var field in row)
                if (field.IsGuessed || field.IsSelected)
                {
                    string output = field.Text.ToString();
                    while (output.Length<14)
                    {
                        output=output + " ";
                    }
                    Console.Write(output);

                }
                else
                {
                    Console.Write("X" + "        ");
                }

            Console.WriteLine();
        }
    }
}