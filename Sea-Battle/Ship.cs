using System;

namespace Sea_Battle
{
    public class Ship
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int XOnField { get; set; }

        public int YOnField { get; set; }

        public int Quadrant { get; set; }

        public int Length { get; set; }

        public int Speed { get; set; }

        public int Range { get; set; }

        public string DirectionOfMoving { get; set; }

        public void Move()
        {
            Console.WriteLine("The ship moving.");
        }

        public static bool operator ==(Ship ship1, Ship ship2)
        {
            if (ship1.Speed == ship2.Speed && ship1.Length == ship2.Length && ship1.GetType() == ship2.GetType())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Ship ship1, Ship ship2)
        {
            if (ship1.Speed != ship2.Speed && ship1.Length != ship2.Length && ship1.GetType() != ship2.GetType())
            {
                return true;
            }
            return false;
        }

        public void ShipInfo ()
        {
            Console.WriteLine($"Ship's length = {Length}");
            Console.WriteLine($"Ship's speed = {Speed}");
            Console.WriteLine($"Ship's position: x = {XOnField}, y = {YOnField}, quadrant = {Quadrant}");
        }
    }
}
