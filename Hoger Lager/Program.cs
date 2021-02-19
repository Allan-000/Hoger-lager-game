using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoger_Lager
{
    class Program
    {

        static void Main(string[] args)
        {

            //welcome messege
            Console.Write("What is your name ? ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Welcome to the game Higher Lower " + playerName);
            Console.WriteLine("The rules are too simpel, The computer generating a deck of cards");
            Console.WriteLine("And you have to guess the next card, is it higher or lower then the current card,");
            Console.WriteLine("Well! are you ready .... press any key to see the card");
            Console.ReadLine();

            Deck deck = new Deck();
            //This line of codes generates the deck of cards
            deck.generateDeck();
            //this line of code gets a random cards from the generated deck
            Console.WriteLine(deck.getRandomCard().Face + " of " + deck.getRandomCard().Suit + deck.getRandomCard().Points());




            Console.ReadLine();

        }

    }
}
