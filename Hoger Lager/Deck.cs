using System;
using System.Collections.Generic;


namespace Hoger_Lager
{
    class Deck
    {
        private string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private string[] suits = { "Diamonds", "Spades", "Clubs", "Hearts" };
        private int[] points = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        List<Card> deck = new List<Card>()
        {

        };

        public void generateDeck()
        {


            for (int i = 0; i < faces.Length; i++)
            {
                  for (int j = 0; j < suits.Length; j++)
                  {
                      deck.Add(new Card(faces[i], suits[j],points[i]));
                  }
            }
        }
        public Card getRandomCard()
        {
            Random rnd = new Random();
            int randompicker = rnd.Next(0, deck.Count);

            return deck[randompicker];
        }


    }



}