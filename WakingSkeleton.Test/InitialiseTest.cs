namespace WakingSkeleton.Test;

[TestFixture]
public class InitialiseTest
{
    [Test]
    public void InitialiseRover()
    {
        Rover rover = new Rover(new int[] { 2, 3 }, "North");

        int[] targetPosition = { 2, 3 };
        string targetDirection = "North";

        Assert.That(rover.Position, Is.EqualTo(targetPosition));
        Assert.That(rover.Direction, Is.EqualTo(targetDirection));
    }
}

public class Rover
{
    public Rover(int[] position, string direction)
    {
        Position = position;
        Direction = direction;
    }
    public int[] Position { get; set; }
    public string Direction { get; set; }
}