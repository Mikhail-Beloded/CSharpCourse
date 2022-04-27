using System;

namespace Sea_Battle
{
    public class Program
    {
        static void Main(string[] args)
        {
            BattleField field = new BattleField();
            field.AddShip();
            field.AddShip();
            bool equal = false;
            if (field.ships[0] == field.ships[1])
            {
                equal = true;
            }

            Console.WriteLine(equal);
        }
    }
}