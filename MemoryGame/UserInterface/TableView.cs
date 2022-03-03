using MemoryGame.Models;

namespace MemoryGame.UserInterface;

public static class TableView
{
    public static void ShowBoard(Boards board)
    {


        foreach (var row in board.Board)
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