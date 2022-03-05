namespace MemoryGame.Models;

public class Word
{
    public Word(string text)
    {
        Text = text;
    }

    public string Text { get; set; }
    public bool IsGuessed { get; set; } = false;
    public bool IsSelected { get; set; } = false;


    public bool Equals(Word other)
    {
        return Text == other.Text;
    }
}