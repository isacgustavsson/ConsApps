namespace MathGame
{
    internal class Menu
    {
    GameEngine engine = new();
    internal void ShowMenu(string name, DateTime date)
        {
            Console.Clear();
            Console.WriteLine($"Hello {name}. Today is {date.DayOfWeek} the {date.Day}th and you are playing the math game.\n ");
            Console.WriteLine("Press any key to show the menu.");
            Console.ReadLine();

            var isGameOn = true;
            do
            {
                Console.WriteLine("-------------------------------------------");                Console.WriteLine("");
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
                        engine.AddGame("Addition game");
                        Console.WriteLine("");
                        break;

                    case "s":
                        engine.SubGame("Subtraction game");
                        Console.WriteLine("");
                        break;

                    case "m":
                        engine.MultGame("Multiplication game");
                        Console.WriteLine("");
                        break;

                    case "d":
                        engine.DivGame("Division game");
                        Console.WriteLine("");
                        break;

                    case "v":
                        Helpers.PrintGames();
                        break;

                    case "q":
                        isGameOn = false;
                        break;
                }
            } while (isGameOn);

        }
    }
}