namespace CardGameApp2
{
    public class Program
    {
        static string choice = "";
        static void Main(string[] args)
        {
            //string[] Suits = { "Hearts", "Spades" }; for testing C:
            //Deck deck = new Deck();
            //deck.SetUpCustomDeck(Suits);
            Game game = new Game();

            //foreach(Card card in deck.SecondDeck)
            //{
            //    Console.WriteLine($"{card.Number} of {card.Suit}");
            //}
            game.StartUp();
        }
    }
}