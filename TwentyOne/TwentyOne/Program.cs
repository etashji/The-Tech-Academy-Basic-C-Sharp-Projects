using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine("There are " + deck.Cards.Count + " cards.");
            Console.ReadLine();
        }
    }
}
