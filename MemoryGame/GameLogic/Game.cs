using MemoryGame.Models;
using MemoryGame.Models.Difficulties;
using MemoryGame.UserInterface;

namespace MemoryGame.GameLogic;

public class Game
{
    private bool Win;

    public Game()
    {
        Difficulty = ReceiveData.ReceiveDifficulty();
        Board = new Boards(Difficulty);
        TableView = new TableView(Board, Difficulty);
        Scoring = new Scoring(Difficulty);
        DataReceiver = new ReceiveData(Board);
    }

    private ReceiveData DataReceiver { get; }

    private Scoring Scoring { get; }

    private IDifficulty Difficulty { get; }
    private Boards Board { get; }
    private TableView TableView { get; }

    public void StartGame()
    {
        do
        {
            Console.Clear();
            TableView.ShowBoard();

            var firstField = DataReceiver.ReceiveField();

            var firstWord = Move.MakeMove(Board, firstField);
            Console.Clear();
            Scoring.StartScoring();
            TableView.ShowBoard();
            var secondField = DataReceiver.ReceiveField();
            var secondWord = Move.MakeMove(Board, secondField);
            Console.Clear();

            TableView.ShowBoard();
            Thread.Sleep(2000);
            if (!firstWord.Equals(secondWord))
            {
                Thread.Sleep(2000);
                Select.SelectField(firstField, Board);
                Select.SelectField(secondField, Board);

                Console.Clear();
                TableView.ShowBoard();
                Scoring.RemoveTry();
            }
            else if (firstWord.Equals(secondWord))
            {
                firstWord.IsGuessed = true;
                secondWord.IsGuessed = true;
            }

            Win = WinChecking.CheckWin(Board);
        } while (Difficulty.Tries > 0 && Win != true);

        var time = Scoring.StopScoring();
        var tries = Difficulty.Tries;

        Console.Clear();
        Console.WriteLine($"Win in: {time} seconds");
        Console.WriteLine($"{tries} Tries left");

        FileHandling.SaveScore(DataReceiver.AskForName(), time, tries);
    }
}