using MemoryGame.Models;

namespace MemoryGame;

public class WordsList
{
    public List<Word> words = new();

    public WordsList()
    {
        ReadWords();
    }
    private void ReadWords()
    {
        //ToDo Zmienić ścieżkę
        foreach (var line in File.ReadAllLines(@"C:\Users\Kuba\source\repos\MemoryGame\MemoryGame\Words.txt"))
        {
            words.Add(new Word(line));
            Console.WriteLine(words);
        }
    }
}