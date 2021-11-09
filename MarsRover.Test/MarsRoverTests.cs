using NUnit.Framework;
using Shouldly;

namespace MarsRover.Test
{
    public class MarsRoverTests
    {
        [Test]
        public void The_rover_accept_a_starting_Point()
        {
            var point = new Point();
            var sut = new Rover(point);
            
            sut.Point.ShouldBeEquivalentTo(point);
        }
    }

    public class Point
    {
    }

    public class Rover
    {
        public Rover(Point point)
        {
            Point = point;
        }

        public Point Point { get; set; }
    }
}