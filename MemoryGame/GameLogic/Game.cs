using MemoryGame.Models;
using MemoryGame.Models.Difficulties;
using MemoryGame.UserInterface;

namespace MemoryGame.GameLogic;

public class Game
{
    public Game()
    {
        Difficulty = ReceiveData.ReceiveDifficulty();
        Board = new Boards(Difficulty);
        TableView = new TableView(Board, Difficulty);
        Scoring = new Scoring(Difficulty);
    }

    private Scoring Scoring { get; }

    private IDifficulty Difficulty { get; }
    private Boards Board { get; }
    private TableView TableView { get; }
    private bool Win = false;

    public void StartGame()
    {
        do
        {
            Console.Clear();
            TableView.ShowBoard();
            var selectedFields = ReceiveData.ReceiveField();
            var selectedWords = Move.MakeMove(Board, selectedFields);
            Console.Clear();
            Scoring.StartScoring();
            TableView.ShowBoard();
            Thread.Sleep(2000);
            if (!selectedWords[0].Equals(selectedWords[1]))
            {
                Thread.Sleep(2000);
                Select.SelectField(selectedFields[0], Board);
                Select.SelectField(selectedFields[1], Board);
                Console.Clear();
                TableView.ShowBoard();
                Scoring.RemoveTry();
            }
            else if(selectedWords[0].Equals(selectedWords[1]))
            {
                selectedWords[0].IsGuessed = true;
                selectedWords[1].IsGuessed = true;
            }

            Win=WinChecking.CheckWin(Board);
        }while(Difficulty.Tries>0&&Win!=true);
        Console.Clear();
        Console.WriteLine($"Win in: {Scoring.StopScoring()} seconds");
        Console.WriteLine($"{Difficulty.Tries} Tries left");

    }
}