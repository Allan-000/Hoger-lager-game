using System;

namespace Hoger_Lager
{
    class Card
    {
        private string face;
        private string suit;
        private int points;//= {2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
        public Card(string face, string suit, int points)
        {
            this.face = face;
            this.suit = suit;
            this.points = points;
        }
        public string Face
        {
            get { return face; }
            set
            {
                if (value == "2" || value == "3" || value == "4" || value == "5" || value == "6" || value == "7" || value == "8" || value == "9" || value == "10" || value == "J" || value == "Q" || value == "K" || value == "A")
                {
                    value = face;
                }
                else
                {
                    value = "not available";
                }
            }
        }
        public string Suit
        {
            get { return suit; }
            set
            {
                if (value == "Diamonds" || value == "Spades" || value == "Clubs" || value == "Hearts")
                {
                    value = suit;
                }
                else
                {
                    value = "not available";
                }
            }
        }
        private int setPoints
        {
            get { return points; }
            set
            {
                if (Face == "2")
                {
                    points = 0;
                }
                else if (Face == "3")
                {
                    points = 1;
                }
                else if (Face == "4")
                {
                    points = 2;
                }
                else if (Face == "5")
                {
                    points = 3;
                }
                else if (Face == "6")
                {
                    points = 4;
                }
                else if (Face == "7")
                {
                    points = 5;
                }
                else if (Face == "8")
                {
                    points = 6;
                }
                else if (Face == "9")
                {
                    points = 7;
                }
                else if (Face == "10")
                {
                    points = 8;
                }
                else if (Face == "J")
                {
                    points = 9;
                }
                else if (Face == "Q")
                {
                    points = 10;
                }
                else if (Face == "K")
                {
                    points = 11;
                }
                else if (Face == "A")
                {
                    points = 12;
                }
                else
                {
                    points = 0;
                    Console.WriteLine("the points of this card is not allowed !");
                }
            }
        }
        public int Points()
        {
            return points;
        }

    }



}