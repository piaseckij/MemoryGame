namespace MemoryGame.UserInterface;

public static class HighScoresHandling
{
    public static void WriteScores()
    {
        Console.WriteLine("\n\n!HIGH SCORES!\n\n");

        var scoresFromFile = FileHandling.ReadScores();
        foreach (var line in scoresFromFile)
        {
            var subs = line.Split("|");
            foreach (var sub in subs) Console.Write(sub + " ");

            Console.WriteLine();
        }
    }
}