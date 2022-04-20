using System;
using System.Collections.Generic;

namespace Sea_Battle
{
    public class Comparer<T> : IComparer<T>
        where T : Ship
    {
        public int Compare(T firstShip, T secondShip)
        {
            if ((firstShip.X ^ 2) < (secondShip.Y ^ 2))
            {
                return 1;
            }
            else if ((firstShip.X ^ 2) == (secondShip.Y ^ 2))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
