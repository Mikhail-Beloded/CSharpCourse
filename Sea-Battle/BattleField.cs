using System;
using System.Collections.Generic;

namespace Sea_Battle
{
    public class BattleField
    {
        public Ship[,] field = new Ship[10, 10];
        public List<Ship> ships = new List<Ship>();

        public void FieldInfo()
        {
            Comparer<Ship> comparer = new Comparer<Ship>();
            ships.Sort(comparer);
            if (ships.Count == 0)
            {
                Console.WriteLine("Field is empty");
            }
            else
            {
                for (int i = 0; i < ships.Count; i++)
                {
                    Console.WriteLine($"Ship number - {i + 1 }: x - {ships[i].X}, y - {ships[i].Y}, quadrant - {ships[i].Quadrant}, length - {ships[i].Length}");
                }
            }
        }

        public void AddShip()
        {
            Ship ship = new Ship();
            ships.Add(ship);
            Console.WriteLine("Choose type od ship: 1 - atack ship, 2 - repair ship, 3 - mix ship");
            int shipType = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out shipType))
                {
                    Console.WriteLine("Incorrect number.");
                }

                if (shipType < 1 || shipType > 3)
                {
                    throw new ArgumentException("Incorrect type of ship.");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }

            Console.WriteLine("Enter x coordinate:");
            int x = 0;

            try
            {
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Incorrect number.");
                }

                if (x < 0 || x > 10)
                {
                    throw new ArgumentException("Incorrect x koordinate");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }

            ship.X = x;
            Console.WriteLine("Enter y coordinate:");
            int y = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Incorrect number.");
                }

                if (y < 0 || y > 10)
                {
                    throw new ArgumentException("Incorrect y koordinate");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }

            ship.Y = y;
            Console.WriteLine("Enter quadrant:");
            int quadrant = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out quadrant))
                {
                    Console.WriteLine("Incorrect number.");
                }

                if (quadrant < 1 || quadrant > 4)
                {
                    throw new ArgumentException("Incorrect y koordinate");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }

            ship.Quadrant = quadrant;

            Console.WriteLine("Enter ship's length:");
            int length = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Incorrect number.");
                }

                if (length > 10 || length < 0)
                {
                    throw new ArgumentException("Incorrect length");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }

            ship.Length = length;
            Console.WriteLine("Choose ship's position: enter 1 - vertical, 2 - horizontal");
            int position = 0;
            try
            {
                if (!int.TryParse(Console.ReadLine(), out position))
                {
                    Console.WriteLine("Incorrect number.");
                }

                if (position < 1 || position > 2)
                {
                    throw new ArgumentException("Incorrect position");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }

            Console.WriteLine("Enter ship's speed:");
            int speed = 0;

            try
            {
                if (!int.TryParse(Console.ReadLine(), out speed))
                {
                    Console.WriteLine("Incorrect number.");
                }

                if (speed < 0 || speed > 10)
                {
                    throw new ArgumentException("Incorrect speed");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }

            ship.Speed = speed;

            Quadrant(quadrant, ref x, ref y);

            if (shipType == 1)
            {
                ship = new AttackShip();
            }
            else if (shipType == 2)
            {
                ship = new RepairShip();
            }
            else if (shipType == 3)
            {
                ship = new MixShip();
            }

            bool permitionToAdd = true;

            for (int i = 0; i < length; i++)
            {
                if (position == 1)
                {
                    if (field[i + y, x] is Ship)
                    {
                        permitionToAdd = false;
                        ships.RemoveAt(ships.Count - 1);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (position == 2)
                {
                    if (field[y, x + i] is Ship)
                    {
                        permitionToAdd = false;
                        ships.RemoveAt(ships.Count - 1);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (permitionToAdd)
            {
                for (int i = 0; i < length; i++)
                {
                    if (position == 1)
                    {
                        field[i + y, x] = ships[ships.Count - 1];
                    }
                    else
                    {
                        field[y, x + i] = ships[ships.Count - 1];
                    }
                }
            }
        }

        private void Quadrant(int quadrant, ref int x, ref int y)
        {
            try
            {
                if (quadrant < 1 || quadrant > 4)
                {
                    throw new ArgumentException("There are only 1, 2, 3, 4 quadrants");
                }

                switch (quadrant)
                {
                    case 1:
                        x = x + 4;
                        y = Math.Abs(y - 5);
                        break;
                    case 2:
                        x = Math.Abs(x - 5);
                        y = Math.Abs(y - 5);
                        break;
                    case 3:
                        x = Math.Abs(x - 5);
                        y = y + 4;
                        break;
                    case 4:
                        x = x + 4;
                        y = y + 4;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error operation {exception.ToString()}");
            }
        }
    }
}