using System;

namespace Sea_Battle
{
    public class MixShip : Ship
    {
        public void Repair()
        {
            Console.WriteLine("Russian warship became a Ukrainian transport ship.");
        }

        public void Attack()
        {
            Console.WriteLine("Russian warship became a submarine.");
        }
    }
}
