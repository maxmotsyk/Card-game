using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp22.CardGame
{
    class PlayMenu
    {
        protected List<Player> list = new List<Player>(2);
        protected GameTable one = new GameTable();
        protected int p1, p2;

        public PlayMenu()
        {
            list.Add(new Player("Max"));
            list.Add(new Player("Tom"));
        }

        public void Menu()
        {
            int choise;
            bool work = true,work2=true;
            while(work)
            {
                Console.WriteLine("[1]-Deal cards\n[2]-Lets Go\n[0]-Exit\n");
                choise = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choise)
                {
                    case 1:
                        one.DecBuilding();
                        СhoosePlaer();
                        Console.Clear();
                        one.DistributionOfCards(list[p1], list[p2]);
                        break;
                    case 2:
                        while(work2)
                        {
                            work2=one.Game(list[p1], list[p2]);
                            Console.Clear();
                        }
                        break;
                    case 0:
                        work = false;
                        break;
                    default:
                        Console.WriteLine("[1]-Deal cards\n[2]-Lets Go\n[0]-Exit\n");
                        choise = int.Parse(Console.ReadLine());
                        break;
                }

            }
        }

        protected void СhoosePlaer()
        {
            try
            {
                Console.WriteLine("Enter player one-");
                p1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter player two-");
                p2 = int.Parse(Console.ReadLine());
                if(p1 > list.Count && p2 > list.Count )
                {
                    throw new Exception("EROR: Dont have this player");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }

   
}
