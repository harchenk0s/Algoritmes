using System;
using System.Collections.Generic;

namespace Algoritmes
{
    public static class Sattolo
    {
        
        public static void Do<T>(IList<T> items)
        {
            Random rand = new Random();
            for (int i = items.Count - 1; i > 1; i--)
            {
                int j = rand.Next(i);
                var tmp = items[i];
                items[i] = items[j];
                items[j] = tmp;
            }
        }
    }
}
