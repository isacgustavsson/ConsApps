/*
You need to create a Math game containing the 4 basic operations

The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

Users should be presented with a menu to choose an operation

You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

You don't need to record results on a database. Once the program is closed the results will be deleted.

*/

var date = DateTime.UtcNow;

var games = new List<string>();

string name = getName();

Menu(name);

string getName()
{
    Console.WriteLine("Please type your name..");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.Clear();
    var isGameOn = true;
    do
    {
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine($"Hello {name}. Today is {date.DayOfWeek} the {date.Day}th and you are playing the math game.\n ");
        Console.WriteLine("What game will you be playing?");
        Console.WriteLine(@"
A - Addition
S - Subtraction
M - Multiplication
D - Division
V - See Game History
Q - Quit the program");
        Console.WriteLine("");
        Console.WriteLine("-------------------------------------------");

        var GameMode = Console.ReadLine().Trim().ToLower();

        switch (GameMode.Trim().ToLower())
        {
            case "a":
                AddGame("Addition game");
                Console.WriteLine("");
                break;

            case "s":
                SubGame("Subtraction game");
                Console.WriteLine("");
                break;

            case "m":
                MultGame("Multiplication game");
                Console.WriteLine("");
                break;

            case "d":
                DivGame("Division game");
                Console.WriteLine("");
                break;

            case "v":
                GetGames();
                break;

            case "q":
                isGameOn = false;
                break;
        }
    } while (isGameOn);

}

void GetGames()
{
    Console.Clear();
    Console.WriteLine("Game History");
    Console.WriteLine("-------------------------------------------");
    foreach (var game in games)
    {
        Console.WriteLine(game);
    }
    Console.WriteLine("-------------------------------------------\n");
    Console.WriteLine("Press Enter to return to the menu.");
    Console.ReadLine();

}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} - {gameType} | Score:{gameScore}");
}

void AddGame(string message)
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

        Console.WriteLine($"{firstNumber} + {secondNumber}");

        var result = Console.ReadLine();

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

    AddToHistory(score, "Addition");
}

void SubGame(string message)
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
        AddToHistory(score, "Subtraction");
}

void MultGame(string message)
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
        AddToHistory(score, "Multiplication");
}

void DivGame(string message)
{
    var score = 0;

       for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divNumbers = GetDivNumbers();
        var firstNumber = divNumbers[0];
        var secondNumber = divNumbers[1];

        Console.WriteLine($"{divNumbers[0]} / {divNumbers[1]}");
        var result = Console.ReadLine();

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
    AddToHistory(score, "Division");
}

int[] GetDivNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    
    {
        firstNumber = random.Next(0, 99);
        secondNumber = random.Next(0, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    Console.WriteLine(result);

    return result;
}