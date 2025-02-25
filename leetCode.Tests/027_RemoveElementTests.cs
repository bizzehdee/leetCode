namespace leetCode.Tests;

[TestFixture]
public class RemoveElementTests
{
    [Test]
    public void Mine_Test1()
    {
        var testData = new int[] { 3, 2, 2, 3 };
        var val = 3;

        var re = new RemoveElement();
        var retVal = re.RemoveElementMine(testData, val);

        Assert.That(retVal, Is.EqualTo(2));
        Assert.That(testData[0], Is.EqualTo(2));
        Assert.That(testData[1], Is.EqualTo(2));
    }

    [Test]
    public void Mine_Test2()
    {
        var testData = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var val = 2;

        var re = new RemoveElement();
        var retVal = re.RemoveElementMine(testData, val);

        Assert.That(retVal, Is.EqualTo(5));
        Assert.That(testData[0], Is.EqualTo(0));
        Assert.That(testData[1], Is.EqualTo(1));
        Assert.That(testData[2], Is.EqualTo(3));
        Assert.That(testData[3], Is.EqualTo(0));
        Assert.That(testData[4], Is.EqualTo(4));
    }
}