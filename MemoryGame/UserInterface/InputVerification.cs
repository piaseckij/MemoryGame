using MemoryGame.Models;

namespace MemoryGame.UserInterface;

public class InputVerification
{
    private readonly Boards _board;
    private readonly string _input;

    public InputVerification(string input, Boards board)
    {
        _input = input;
        _board = board;
    }

    public bool VerifyLength()
    {
        return _input.Length == 2;
    }

    public bool VerifyOutOfRange(int column, char row)
    {
        return row is 'A' or 'B' && column < _board.Board[0].Count+1 && column < _board.Board[1].Count+1;
    }
}