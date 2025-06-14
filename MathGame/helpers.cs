using ConsApps.MathGame.Models;

namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();
             internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("-------------------------------------------");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}pts");
            }
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();

        }
        internal static int[] GetDivNumbers()
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
    }
}