using MemoryGame.Models;

namespace MemoryGame;

public class WordsList
{
    public List<Word> Words = new();

    public WordsList()
    {
        ReadWords();
    }
    private void ReadWords()
    {
        //ToDo Zmienić ścieżkę
        foreach (var line in File.ReadAllLines(@"C:\Users\Kuba\source\repos\MemoryGame\MemoryGame\Resources\Words.txt"))
        {
            Words.Add(new Word(line));
        }
    }
}