using System;
using System.Collections.Generic;

namespace Algoritmes
{
    public class HanoiTower
    {
        List<List<int>> tower = new List<List<int>>();
        int towerHeight;
        IStrategy strategy;

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

            //for (int i = 1; i < 3; i++)
            //{
            //    for (int j = 1; j <= TowerHeight; j++)
            //    {
            //        tower[i].Add(0);
            //    }
            //}
            ShowTowers();
        }


        public void Solve(IStrategy strategy)
        {

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
                    //if(tower[j][i] == 0)
                    //{
                    //    Console.Write("       |       ");
                    //}
                    //else
                    //{
                    //    Console.Write($"       {tower[j][i]}       ");
                    //}
                    try
                    {
                        Console.Write($"       {tower[j][i]}       ");
                    }
                    catch (Exception ex)
                    {
                        Console.Write("       |       ");
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("__________________________________________________________________");
        }
    }


    public interface IStrategy
    {
        void Algorithm(List<List<int>> towers);

        
    }


    class EvenNumberAlgorithm : IStrategy
    {
        public void Algorithm(List<List<int>> towers)
        {

            int countSteps = Convert.ToInt32(Math.Pow(2, towers[0].Count) - 1);

            for (int i = 0; i < countSteps; i++)
            {

            }
        }

        void Swap(List<List<int>> towers, int posA, int posB)
        {
            if ()
            {

            }
            else
            {

            }
        }

    }


    class OddNumberAlgorithm : IStrategy
    {
        public void Algorithm(List<List<int>> towers)
        {

        }
    }
}
