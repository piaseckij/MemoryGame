using MemoryGame.GameLogic;
using MemoryGame.Models;
using MemoryGame.Models.Difficulties;

namespace MemoryGame.UserInterface;

public class ReceiveData
{
    private readonly Boards _board;

    public ReceiveData(Boards board)
    {
        _board = board;
    }
    public  List<UserSelection> ReceiveField()
    {

        List<UserSelection> output = new();
        var inputCorrect = true;
        do
        {
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("Select Field: ");
                var input = Console.ReadLine();
                var row = 0;

                var inputVerification = new InputVerification(input,_board);

                switch (input[0])
                {
                    case 'A':
                    {
                        row = 0;
                        break;
                    }
                    case 'B':
                    {
                        row = 1;
                        break;
                        
                    }

                }

                if (!inputVerification.VerifyLength())
                {
                    Console.WriteLine("Bad Input. Try Uppercase and number ex. A1");
                    Thread.Sleep(1500);
                    inputCorrect = false;
                    break;
                }
                
                var success = int.TryParse("" + input[1], out var column);


                if (!success||!inputVerification.VerifyOutOfRange(column, row))
                {
                    Console.WriteLine("Bad Input. Try Uppercase and number ex. A1");
                    Thread.Sleep(1500);
                    inputCorrect = false;
                    break;
                }

                output.Add(new UserSelection(row, column));
                inputCorrect = true;
            }
        } while (!inputCorrect);

        return output;
    }

    public static IDifficulty ReceiveDifficulty()
    {
        var inputCorrect = false;
        var level = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("What Difficulty you want?");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Hard");

            var input = Console.ReadLine();

            var success = int.TryParse(input, out level);

            if (success && level.ToString().Length == 1 && level is 1 or 2)
            {
                inputCorrect = true;
            }
            else
            {
                Console.WriteLine("Wrong input");
                Thread.Sleep(1500);
            }
        } while (!inputCorrect);

        switch (level)
        {
            case 1:
                return new Easy();
            case 2:
                return new Hard();
            default:
                return new Easy();
        }
    }
}