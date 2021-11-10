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

        [Test]
        public void Point_contains_X_and_Y()
        {
            var point = new Point {X = 1, Y = 2};
            
            var sut = new Rover(point);
            
            sut.Point.X.ShouldBe(1);
            sut.Point.Y.ShouldBe(2);
        }

        [Test]
        public void Rover_can_move_down()
        {
            var point = new Point {X = 1, Y = 1};
            
            var sut = new Rover(point);

            sut.Move(new[] {"f", "f"});
            
            sut.Point.X.ShouldBe(3);
        }
    }
}