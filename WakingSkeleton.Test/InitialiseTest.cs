namespace WakingSkeleton.Test;

[TestFixture]
public class InitialiseTest
{
    [Test]
    public void InitialiseRover()
    {
        Rover rover = new Rover(new int[] { 2, 3 }, "North");

        int[] targetPosition = new int[] { 2, 3 };
        string targetDirection = "North";

        Assert.That(rover.Position, Is.EqualTo(targetPosition));
        Assert.That(rover.Direction, Is.EqualTo(targetDirection));
    }
}