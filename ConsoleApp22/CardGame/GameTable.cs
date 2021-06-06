using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22.CardGame
{
    class GameTable
    {
        public  Dictionary<int, Card> Deck = new Dictionary<int, Card>(36);

        public bool Game (Player one, Player two)
        {
            int choise,choise2;

            if(one.dic.Count != 0 || two.dic.Count != 0)
            {
                try
                {
                    one.ShowMyCards();
                    Console.WriteLine("Player one put the card");
                    choise = int.Parse(Console.ReadLine());
                    Console.Clear();

                    two.ShowMyCards();
                    Console.WriteLine("Player two put the card");
                    choise2 = int.Parse(Console.ReadLine());

                    if(choise > one.dic.Count && choise2 >two.dic.Count )
                    {
                        throw new Exception("You do not have such a card");
                    }

                    if (one.dic[choise] > two.dic[choise2])
                    {
                        two.dic.Add(two.dic.Count+1, one.dic[choise]);
                        one.dic.Remove(choise);
                    }

                    if(one.dic[choise] == two.dic[choise2])
                    {
                        Console.WriteLine("cards are equal");
                    }

                    else
                    {
                        one.dic.Add(one.dic.Count+1, two.dic[choise2]);
                        two.dic.Remove(choise2);
                    }

                    return true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            } 
            else
            {
                if(one.dic.Count == 0)
                {
                    Console.WriteLine($"WINER::{one.Name}");
                    return false;
                }
                else
                {
                    Console.WriteLine($"WINER::{two.Name}");
                    return false;
                }
            }
            return false;
           
        }

        public void DecBuilding()
        {
            int n,t;
            Random rnd1 = new Random();
            for (int i =0;i<36;i++)
            {
                n = rnd1.Next(0, 8);
                t = rnd1.Next(0, 8);
                Deck.Add(i,new Card(n, (Suit)t));
            }
        }

        public void DistributionOfCards(Player one, Player two)
        {
            for (int i = 0; i <= 17 ;i++)
            {
                one.dic.Add(one.dic.Count + 1,Deck[i]);
            }

            for(int i = 17;i <= 35 ;i++)
            {
                two.dic.Add(two.dic.Count + 1, Deck[i]);
            }
        }

    }
}
