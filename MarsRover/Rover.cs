using MarsRover.Enums;

namespace MarsRover
{
    public class Rover
    {
        public Rover(Point position)
        {
            Position = position;
            Direction = Directions.South;
        }

        public Point Position { get; }
        public string Direction { get; private set; }

        public void Move(string[] commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
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
                    default:
                        if(Direction == Directions.South)
                            MoveSouth(command);
                        if(Direction == Directions.East)
                            MoveEast(command);
                        if(Direction == Directions.West)
                            MoveWest(command);
                        if(Direction == Directions.North)
                            MoveNorth(command);
                        break;
                }
            }
        }

        void MoveSouth(string command)
        {
            switch (command)
            {
                case "f":
                    Position.X += 1;
                    break;
                case "b":
                    Position.X -= 1;
                    break;
                case "l":
                    Position.Y += 1;
                    break;
                case "r":
                    Position.Y -= 1;
                    break;
            }
        }

        void MoveNorth(string command)
        {
            switch (command)
            {
                case "f":
                    Position.X -= 1;
                    break;
                case "b":
                    Position.X += 1;
                    break;
                case "l":
                    Position.Y -= 1;
                    break;
                case "r":
                    Position.Y += 1;
                    break;
            }
        }
        void MoveWest(string command)
        {
            switch (command)
            {
                case "f":
                    Position.Y -= 1;
                    break;
                case "b":
                    Position.Y += 1;
                    break;
                case "l":
                    Position.X += 1;
                    break;
                case "r":
                    Position.X -= 1;
                    break;
            }
        }
        void MoveEast(string command)
        {
            switch (command)
            {
                case "f":
                    Position.Y += 1;
                    break;
                case "b":
                    Position.Y -= 1;
                    break;
                case "l":
                    Position.X -= 1;
                    break;
                case "r":
                    Position.X += 1;
                    break;
            }
        }
    }
    
}