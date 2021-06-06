using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22.CardGame
{
    class Card
    {
        public int Number { get; set; }
        public Suit suit;

        public Card(int number, Suit t)
        {
            this.suit = t;
            this.Number = number;
        }

        public static bool operator >(Card one, Card two)
        {
            return one.Number > two.Number && one.suit > two.suit;
        }

        public static bool operator <(Card one, Card two)
        {
            return one.Number < two.Number && one.suit < two.suit;
        }

        public static bool operator == (Card one, Card two)
        {
            return one.Number == two.Number && one.suit == two.suit;
        }

        public static bool operator !=(Card one, Card two)
        {
            return one.Number != two.Number && one.suit != two.suit;
        }

        public override string ToString()

        {
            return $"numeral-{Number} suit-{suit}";
        }
    }

    enum Suit
    {
        Hearts ,
        Diamonds ,
        Clubs ,
        Spades ,
        Jack ,
        Queen ,
        King ,
        Ace ,
        Joker 
    }

}
