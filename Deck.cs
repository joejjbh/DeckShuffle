using System;

namespace CardProject
{
    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int NUMBER_OF_CARDS = 52;
        private Random ranNum;

        public Deck()
        {
            // state the possible face values of the cards into an array
            string[] values = { "Ace", "Two", "Three", "Four", "Five", "Six",
                                "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            // state the possible suits that the cards can have into an array
            string[] suits =  { "Hearts", "Clubs", "Diamonds", "Spades" };
            // initialise a new instance of Card that has the number of cards as 52
            deck = new Card[NUMBER_OF_CARDS];
            // set the current current card to 0
            currentCard = 0;
            // create a new instance of Random()
            ranNum = new Random();
            // populate the deck
            for (int count = 0; count < deck.Length; count++)
            {
                deck[count] = new Card(values[count % 13], suits[count / 13]);
            }
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = ranNum.Next(NUMBER_OF_CARDS); // get a random number from the 52 possible cards
                Card temp = deck[first]; // store the first card in variable temp
                deck[first] = deck[second]; //  store second into first 
                deck[second] = temp; // store temp into second
            }
        }

        public Card DealCard()
        {
            if (currentCard < deck.Length)
            {
                return deck[currentCard++];
            }
            else
            {
                return null;
            }
        }
    }
}
