using NUnit.Framework;

namespace OneHundredDoors;

[TestFixture]
public class DoorsTest
{
    [TestCase(true, false)]
    [TestCase(false, true)]
    public void Toggle(bool door, bool expected)
    {
        Assert.That(Doors.Toggle(door), Is.EqualTo(expected));
    }

    [TestCase(1, true, true, true, true, true, true)]
    [TestCase(2, false, true, false, true, false, true)]
    [TestCase(3, false, false, true, false, false, true)]
    public void Pass(int iteration, params bool[] expected)
    {
        var doors = new[] { false, false, false, false, false, false };

        Assert.That(Doors.Pass(doors, iteration), Is.EquivalentTo(expected));
    }

    [Test]
    public void FirstTwoPasses()
    {
        var doors = new[] { false, false, false, false, false, false };
        var expected = new[] { true, false, true, false, true, false };

        Assert.That(Doors.Iterate(doors, 2), Is.EquivalentTo(expected));
    }

    [Test]
    public void FirstThreePasses()
    {
        var doors = new[] { false, false, false, false, false, false };
        var expected = new[] { true, false, false, false, true, true };

        Assert.That(Doors.Iterate(doors, 3), Is.EquivalentTo(expected));
    }
}