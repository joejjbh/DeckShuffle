using System;

namespace CardProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuffle();
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0,-19}", myDeck.DealCard());
                if ((i + 1) % 4 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
