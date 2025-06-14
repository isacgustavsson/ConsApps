using ConsApps.MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AddGame(string message)
{
    var score = 0;
    var random = new Random();
    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");

                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Correct answer! Type any key for the next question..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Type any key for the next question..");
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game Over! Your final score is: {score}");
                }
            }

    Helpers.AddToHistory(score, GameType.Addition);
}

        internal void SubGame(string message)
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var random = new Random();
        int firstNumber;
        int secondNumber;

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        
        var result = Console.ReadLine();
        result = Helpers.ValidateResult(result);
    
        if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Type any key for the next question..");
                    Console.ReadLine();
                }

        if (i == 4)
        {
            Console.WriteLine($"Game Over. Your final score is {score}.");
        }
    }
    Helpers.AddToHistory(score, GameType.Subtraction);
}

        internal void MultGame(string message)
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var Random = new Random();

        int firstNumber;
        int secondNumber;
        firstNumber = Random.Next(1, 9);
        secondNumber = Random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");

        var result = Console.ReadLine();
        result = Helpers.ValidateResult(result);

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct answer. Type any key for the next question..");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Incorrect answer. Type any key for the next question..");
            Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game Over. Your final score is: {score}");
        }
    }
        Helpers.AddToHistory(score, GameType.Multiplication);
}

        internal void DivGame(string message)
{
    var score = 0;

       for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divNumbers = Helpers.GetDivNumbers();
        var firstNumber = divNumbers[0];
        var secondNumber = divNumbers[1];

        Console.WriteLine($"{divNumbers[0]} / {divNumbers[1]}");
        
        var result = Console.ReadLine();
        result = Helpers.ValidateResult(result);


        if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Correct answer. Type any key for the next question..");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Incorrect answer. Type any key for the next question..");
                    Console.ReadLine();

                }

        if (i == 4)
        {
            Console.WriteLine($"Game Over. Your final score is: {score}");
        }
    }
    Helpers.AddToHistory(score, GameType.Division);
}
    }
}