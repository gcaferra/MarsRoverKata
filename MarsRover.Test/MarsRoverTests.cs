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
        public void Rover_can_move_forward()
        {
            var point = new Point {X = 1, Y = 1};
            
            var sut = new Rover(point);

            sut.Move(new[] {"f", "f"});
            
            sut.Point.X.ShouldBe(3);
        }

        [Test]
        public void Rover_can_move_backward()
        {
            var point = new Point {X = 3, Y = 3};
            
            var sut = new Rover(point);

            sut.Move(new[] {"b", "b"});
            
            sut.Point.X.ShouldBe(1);
        }

        [Test]
        public void the_Rover_can_move_on_left()
        {
            var point = new Point {X = 1, Y = 3};
            
            var sut = new Rover(point);

            sut.Move(new[] {"l", "l"});
            
            sut.Point.Y.ShouldBe(1);
        }

        [Test]
        public void the_Rover_can_move_on_Right()
        {
            var point = new Point {X = 1, Y = 3};
            
            var sut = new Rover(point);

            sut.Move(new[] {"r", "r"});
            
            sut.Point.Y.ShouldBe(5);
        }

        [Test]
        public void Unknown_commands_are_ignored()
        {
            var point = new Point {X = 1, Y = 3};
            
            var sut = new Rover(point);

            sut.Move(new[] {"1", "e","d","q"});
            
            sut.Point.ShouldBeEquivalentTo(point);
        }

        [Test]
        public void several_commands_are_executed_in_sequence()
        {
            var point = new Point {X = 1, Y = 1};
            var expected = new Point {X = 2, Y = 2};
            
            var sut = new Rover(point);

            sut.Move(new[] {Commands.Forward, Commands.Forward, Commands.Right, Commands.Right, Commands.Left, Commands.Backward});
            
            sut.Point.ShouldBeEquivalentTo(expected);
        }
    }
}