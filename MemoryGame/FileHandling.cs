namespace MemoryGame;

public static class FileHandling
{
    public static List<string> ReadWordsFromFile()
    {
        return File.ReadAllLines(@"..\..\..\Resources\Words.txt").ToList();
    }

    public static void SaveScore(string name, int guessingTime, int guessingTries)
    {
        var path = @"..\..\..\Resources\HighScores.txt";

        var line = $"{name}|{DateTime.Now.Date}|{guessingTime}|{guessingTries}";

        File.AppendAllLines(path, new[] {line});
    }

    public static List<string> ReadScores()
    {
        var path = @"..\..\..\Resources\HighScores.txt";

        return File.ReadAllLines(path).ToList();
    }
}