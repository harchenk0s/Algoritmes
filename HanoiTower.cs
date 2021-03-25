using System;
using System.Collections.Generic;

namespace Algoritmes
{
    public class HanoiTower
    {
        List<List<int>> tower = new List<List<int>>();
        int towerHeight;

        public HanoiTower(int TowerHeight)
        {
            towerHeight = TowerHeight;

            for (int i = 0; i < 3; i++)
            {
                tower.Add(new List<int>());
            }

            for (int i = 1; i <= TowerHeight; i++)
            {
                tower[0].Add(i);
            }

            for (int i = 1; i < 3; i++)
            {
                for (int j = 1; j <= TowerHeight; j++)
                {
                    tower[i].Add(0);
                }
            }
            ShowTowers();
        }

        void ShowTowers()
        {
            Console.Clear();
            Console.WriteLine("==================================================================");
            Console.WriteLine("                                                                  \n");

            for (int i = 0; i < towerHeight; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(tower[j][i] == 0)
                    {
                        Console.Write("       |       ");
                    }
                    else
                    {
                        Console.Write($"       {tower[j][i]}       ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("__________________________________________________________________");


        }
    }
}
