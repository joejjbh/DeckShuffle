namespace CardProject
{
    public class Card
    {
        private string value;
        private string suit;
        
        public Card(string cardValue, string cardSuit)
        {
            // consturctor
            suit = cardSuit;
            value = cardValue;
        }

        public override string ToString()
        {
            // how cards are to be displayed
            return value + " of " + suit;
        }
    }
}
