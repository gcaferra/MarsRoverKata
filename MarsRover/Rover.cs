using MarsRover.Enums;

namespace MarsRover
{
    public class Rover
    {
        public Rover(Point position)
        {
            Position = position;
            Direction = Directions.North;
        }

        public Point Position { get; }
        public string Direction { get; private set; }

        public void Move(string[] commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case "f":
                        Position.X = Forward(Position.X);
                        break;
                    case "b":
                        Position.X = Backward(Position.X);
                        break;
                    case "l":
                        Position.Y = Backward(Position.Y);
                        break;
                    case "r":
                        Position.Y = Forward(Position.Y);
                        break;
                    case Directions.West:
                        Direction = Directions.West;
                        break;
                    case Directions.North:
                        Direction = Directions.North;
                        break;
                    case Directions.East:
                        Direction = Directions.East;
                        break;
                    case Directions.South:
                        Direction = Directions.South;
                        break;
                }
            }
        }
        
        static int Forward(int position) => ++position;

        static int Backward(int position) => --position;
    }
    
}