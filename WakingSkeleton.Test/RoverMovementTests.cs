namespace WakingSkeleton.Test;

[TestFixture]
public class RoverMovementTests
{
    [Test]
    public void MoveBackwardsTest()
    {
        Rover rover = new Rover(new int[] { 1, 1 }, "North");
        int[] targetPosition = { 1, 0 };

        rover.Command("B", rover.Direction);
    
        Assert.That(rover.Position, Is.EqualTo(targetPosition));
    }

    [Test]
    public void MoveForwardTest()
    {
        Rover rover = new Rover(new int[] { 1, 1 }, "North");

        int[] targetPosition = { 1, 2 };

        rover.Command("F", rover.Direction);

        Assert.That(rover.Position, Is.EqualTo(targetPosition));

    }
}