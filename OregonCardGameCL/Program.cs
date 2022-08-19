using OregonCardGame.Controller;
using OregonCardGame.Model;

namespace Program
{
    internal class Interface
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            while (!game.GameOver)
            {
                Console.WriteLine("Current total score: " + game.Score);
                Console.WriteLine("Current hand score: " + game.LayoutScore);
                Console.WriteLine("Deck: " + game.CardsInDeck + " cards");
                Console.WriteLine("Drawn card: " + game.AvailableCard);
                Console.WriteLine("Hand: " + game.CardsInLayout);
                Console.WriteLine("\nStart a new layout(s) or place(p)?");
                var input = Console.ReadLine();
                if (input.Contains('s'))
                {
                    game.StartNewLayout();
                }
                else if (input.Contains('p')) {
                    Console.WriteLine("Where do you want to place? It can go anywhere from 0 to " + game.HighestAvailableIndex);
                    var idx = Convert.ToInt32(Console.ReadLine());
                    if (idx < 0 || idx > game.HighestAvailableIndex)
                    {
                        Console.WriteLine("That's outside the available indexes.");
                    }
                    else{
                        game.PlaceCard(idx);
                    }
                }
            }
            Console.WriteLine("Final score: " + game.Score);
        }
    }
}
