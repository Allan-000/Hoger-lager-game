using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoger_Lager
{
    class Program
    {
        public static string playerName;
        private static int cardOntable;
        private static int playerGuess;
        private static int playerCredits;
        static bool tryAgain = true;
        static void Main(string[] args)
        {

            //cheacking the age of the player
            Console.WriteLine("Helle there, how old are you");
            int playerAge = Convert.ToInt32(Console.ReadLine());
            if (playerAge >= 18)
            {
                Console.Write("What is your name ? ");
                playerName = Console.ReadLine();
                Console.WriteLine("Welcome to the game Higher Lower " + playerName);
                Console.WriteLine("The rules are too simpel, The computer generating a deck of cards");
                Console.WriteLine("And you have to guess the next card, is it higher or lower then the current card,");
                Console.WriteLine("Well! are you ready .... press any key to see the card");
                Console.ReadLine();
                //this while loop repeats the guessing process
                while (tryAgain)
                {
                    Deck deck = new Deck();
                    //This line of codes generates the deck of cards
                    deck.generateDeck();
                    //this line of code gets a random cards from the generated deck
                    Console.WriteLine(deck.getRandomCard().Face + " of " + deck.getRandomCard().Suit);
                    cardOntable = deck.getRandomCard().Points();
                    Console.WriteLine("Higer or Lower ?  choose h or l");
                    if (Console.ReadLine() == "h")
                    {
                        playerGuess = cardOntable++;
                    }
                    else
                    {
                        playerGuess = cardOntable--;
                    }
                    if (deck.getRandomCard().Points() < playerGuess)
                    {
                        Console.WriteLine("CORRECT GUESSED, you got one credits");
                        playerCredits++;
                    }
                    else if (deck.getRandomCard().Points() == playerGuess)
                    {
                        Console.WriteLine("WoW,,,You are so lucky");
                        Console.WriteLine("you got ten credits");
                        playerCredits=playerCredits+10;
                    }
                    else
                    {
                        Console.WriteLine("UNFORTUATLY, you guessed wrong");
                        playerCredits--;
                    }
                    Console.WriteLine("your total credits are "+ playerCredits);
                }
                
            }
            else
            {
                Console.WriteLine("sorry but you can not play this game because you are too young");
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            

        }

    }
}
