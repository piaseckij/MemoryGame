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

    private ReceiveData DataReceiver { get; set; }

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


            var fields = DataReceiver.ReceiveField();


            var selectedFields = fields.ToList();


            var selectedWords = Move.MakeMove(Board, selectedFields);
            Console.Clear();
            Scoring.StartScoring();
            TableView.ShowBoard();
            Thread.Sleep(2000);
            if (!selectedWords[0].Equals(selectedWords[1]))
            {
                Thread.Sleep(2000);
                Select.SelectField(selectedFields, Board);
                Console.Clear();
                TableView.ShowBoard();
                Scoring.RemoveTry();
            }
            else if (selectedWords[0].Equals(selectedWords[1]))
            {
                selectedWords[0].IsGuessed = true;
                selectedWords[1].IsGuessed = true;
            }

            Win = WinChecking.CheckWin(Board);
        } while (Difficulty.Tries > 0 && Win != true);

        Console.Clear();
        Console.WriteLine($"Win in: {Scoring.StopScoring()} seconds");
        Console.WriteLine($"{Difficulty.Tries} Tries left");
    }
}