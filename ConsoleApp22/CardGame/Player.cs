using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22.CardGame
{
    class Player
    {
        public string  Name { get; set; }
        public  Dictionary<int,Card> dic = new Dictionary<int, Card>(18);

        public Player(string name)
        {
            this.Name = name;
        } 

        public Player ()
        {
            this.Name = "";
        }

        public void ShowMyCards()
        {
            foreach(int i in dic.Keys)
            {
                Console.WriteLine($"#{i} card-{dic[i]}");
            }
            Console.WriteLine();
        }

    }
}
