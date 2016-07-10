namespace CardProject
{
    public class Card
    {
        private string value;
        private string suit;
        
        public Card(string cardValue, string cardSuit)
        {
            suit = cardSuit;
            value = cardValue;
        }

        public override string ToString()
        {
            return value + " of " + suit;
        }
    }
}
