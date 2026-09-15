namespace WakingSkeleton.Test;

[TestFixture]
public class InitialiseTest
{
    [Test]
    public void initialiseRover()
    {
        Rover rover = new Rover();

        int[] TargetPosition = new int[] { 2, 3 };
        string TargetDirection = "North";

        Assert.That(rover.position, Is.EqualTo(TargetPosition));
        Assert.That(rover.direction, Is.EqualTo(TargetDirection));
    }
}

public class Rover
{
    public int[] position { get; set; } = new int[] { 2, 3 };
    public string direction { get; set; } = "North";
}