namespace MemoryGame.Models;

public class UserSelection
{
    public UserSelection(int line, int column)
    {
        Line = line;
        Column = column;
    }

    public int Line { get; set; }
    public int Column { get; set; }


    protected bool Equals(UserSelection other)
    {
        return Line == other.Line && Column == other.Column;
    }
}