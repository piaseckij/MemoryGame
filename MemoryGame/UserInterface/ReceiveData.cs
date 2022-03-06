using MemoryGame.Models;
using MemoryGame.Models.Difficulties;

namespace MemoryGame.UserInterface;

public class ReceiveData
{
    private readonly InputVerification _inputVerification;

    public ReceiveData(Boards board)
    {
        _inputVerification = new InputVerification(board);
    }

    public UserSelection ReceiveField()
    {
        var inputCorrect = true;
        UserSelection output;
        do
        {
            Console.WriteLine("\nSelect Field: (ex.A1)");
            var input = Console.ReadLine();

            var row = input[0] switch
            {
                'A' => 0,
                'B' => 1,
                _ => 0
            };

            if (!_inputVerification.VerifyLength(input))
            {
                Console.WriteLine("Bad Input. Try Uppercase and number ex. A1");
                Thread.Sleep(1500);
                inputCorrect = false;
            }

            var success = int.TryParse("" + input[1], out var column);


            if (!success || !_inputVerification.VerifyOutOfRange(column, row))
            {
                Console.WriteLine("Bad Input. Try Uppercase and number ex. A1");
                Thread.Sleep(1500);
                inputCorrect = false;
            }

            output = new UserSelection(row, column);
            inputCorrect = true;
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

    public static bool RestartQuestion()
    {
        var inputCorrect = false;

        do
        {
            Console.WriteLine("Do you want to try again?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            var input = Console.ReadLine();

            var success = int.TryParse(input, out var afterParse);
            if (afterParse is not 1 or 2)
                return false;

            if (success && afterParse.ToString().Length == 1)
            {
                inputCorrect = true;
                return true;
            }

            Console.WriteLine("Wrong input");
            Thread.Sleep(1500);

            return false;
        } while (!inputCorrect);
    }

    public string AskForName()
    {
        var success = false;
        string name;

        do
        {
            Console.WriteLine("\nWhat's your name?");

            name = Console.ReadLine();

            success = _inputVerification.VerifyName(name);
        } while (!success);

        return name;
    }
}