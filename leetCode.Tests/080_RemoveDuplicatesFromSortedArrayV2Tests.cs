namespace leetCode.Tests;

[TestFixture]
public class RemoveDuplicatesFromSortedArrayV2Tests
{
    [Test]
    public void Mine_Test1()
    {
        var testData = new int[] { 1, 1, 1, 2, 2, 3 };

        var rd = new RemoveDuplicatesFromSortedArrayV2();
        var r = rd.RemoveDuplicatesFromSortedArrayV2Mine(testData);

        Assert.That(r, Is.EqualTo(5));
        Assert.That(testData[0], Is.EqualTo(1));
        Assert.That(testData[1], Is.EqualTo(1));
        Assert.That(testData[2], Is.EqualTo(2));
        Assert.That(testData[3], Is.EqualTo(2));
        Assert.That(testData[4], Is.EqualTo(3));
    }

    [Test]
    public void Mine_Test2()
    {
        var testData = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

        var rd = new RemoveDuplicatesFromSortedArrayV2();
        var r = rd.RemoveDuplicatesFromSortedArrayV2Mine(testData);

        Assert.That(r, Is.EqualTo(7));
        Assert.That(testData[0], Is.EqualTo(0));
        Assert.That(testData[1], Is.EqualTo(0));
        Assert.That(testData[2], Is.EqualTo(1));
        Assert.That(testData[3], Is.EqualTo(1));
        Assert.That(testData[4], Is.EqualTo(2));
        Assert.That(testData[5], Is.EqualTo(3));
        Assert.That(testData[6], Is.EqualTo(3));
    }
}