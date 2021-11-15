using MarsRover.Enums;

namespace MarsRover
{
    public class Rover
    {
        public Rover(Point point)
        {
            Point = point;
        }

        public Point Point { get; }
        public Directions Direction { get; set; }

        public void Move(string[] commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case "f":
                        Point.X++;
                        break;
                    case "b":
                        Point.X--;
                        break;
                    case "l":
                        Point.Y--;
                        break;
                    case "r":
                        Point.Y++;
                        break;
                }
            }
        }
    }
    
}