using MemoryGame.Models;

namespace MemoryGame.UserInterface;

public class InputVerification
{
    private readonly Boards _board;


    public InputVerification(Boards board)
    {
        _board = board;
    }

    public bool VerifyLength(string input)
    {
        return input.Length == 2;
    }

    public bool VerifyOutOfRange(int column, int row)
    {
        return row is 0 or 1 && column < _board.Board[0].Count + 1 && column < _board.Board[1].Count + 1;
    }

    public bool VerifyName(string name)
    {
        return name is {Length: < 25};
    }
}