/*
You need to create a Math game containing the 4 basic operations

The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

Users should be presented with a menu to choose an operation

You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

You don't need to record results on a database. Once the program is closed the results will be deleted.

*/

var date = DateTime.UtcNow;
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
Q - Quit the program");
    Console.WriteLine("");
    Console.WriteLine("-------------------------------------------");

    var GameMode = Console.ReadLine().Trim().ToLower();

    switch (GameMode.Trim().ToLower())
    {
        case "a":
            AddGame($"Addition game");
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

        case "q":
            Environment.Exit(1);
            break;
    }
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


}

int[] GetDivNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(0, 99);
        secondNumber = random.Next(0, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    Console.WriteLine(result);

    return result;
}


// Game mode menu using If Else statements instead of the Switch method below.
// if (GameMode == "a") 
// {
//             AddGame("Addition Game Selected");
// } 
// else if (GameMode == "s") 
// {
//     SubGame("Subtraction Game Selected");
// } 
// else if (GameMode == "m") 
// {
//     MultGame("Multiplication Game Selected");
// } 
// else if (GameMode == "d") 
// {
//     DivGame("Division Game Selected");
// } 
// else if (GameMode == "q") {
//         Console.WriteLine("Thanks For Playing!");
//         Environment.Exit(1);
// } 
// else {
//     Console.WriteLine("Invalid Input, Please Try Again..");
// }