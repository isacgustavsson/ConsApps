/*
You need to create a Math game containing the 4 basic operations

The divisions should result on INTEGERS ONLY and dividends should go from 0 to 100. Example: Your app shouldn't present the division 7/2 to the user, since it doesn't result in an integer.

Users should be presented with a menu to choose an operation

You should record previous games in a List and there should be an option in the menu for the user to visualize a history of previous games.

You don't need to record results on a database. Once the program is closed the results will be deleted.

*/

// This code is executed immediately after running "dotnet run"
Console.WriteLine("\n");
Console.WriteLine("Please type your name..");

/* Code stops execution at this line, waiting for input.
Pausing execution and waiting for input is normal behaviour for Console.ReadLine() in Console Applications. */

var name = Console.ReadLine();

Menu(Console.ReadLine(), DateTime.UtcNow);

void Menu(string? name, DateTime date)
{
    Console.WriteLine("\n");
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("\n");
    Console.WriteLine($"Hello {name}. Today is {date.DayOfWeek} the {date.Day}th and you are playing the math game.\n ");
    Console.WriteLine("What game will you be playing?");
    Console.WriteLine(@"
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("\n");
    Console.WriteLine("-------------------------------------------");

    var GameMode = Console.ReadLine().Trim().ToLower();

    switch (GameMode.Trim().ToLower())
    {
        case "a":
            AddGame("Addition game selected.");
            break;

        case "s":
            SubGame("Subtraction game selected.");
            break;

        case "m":
            MultGame("Multiplication game selected.");
            break;

        case "d":
            DivGame("Division game selected");
            break;

        case "q":
            Environment.Exit(1);
            break;
    }
}

void AddGame(string message) 
{
    Console.WriteLine(message);
}

void SubGame(string message)
{
    Console.WriteLine(message);
}

void MultGame(string message) 
{
    Console.WriteLine(message);
}

void DivGame(string message)
{
    Console.WriteLine(message);
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