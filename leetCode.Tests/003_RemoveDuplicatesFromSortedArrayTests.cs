namespace leetCode.Tests;

[TestFixture]
public class RemoveDuplicatesFromSortedArrayTests
{
    [Test]
    public void Mine_Test1()
    {
        var testData = new int[] { 1, 1, 2 };

        var rd = new RemoveDuplicatesFromSortedArray();
        var r = rd.RemoveDuplicatesFromSortedArrayMine(testData);

        Assert.That(r, Is.EqualTo(2));
        Assert.That(testData[0], Is.EqualTo(1));
        Assert.That(testData[1], Is.EqualTo(2));
    }

    [Test]
    public void Mine_Test2()
    {
        var testData = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        var rd = new RemoveDuplicatesFromSortedArray();
        var r = rd.RemoveDuplicatesFromSortedArrayMine(testData);

        Assert.That(r, Is.EqualTo(5));
        Assert.That(testData[0], Is.EqualTo(0));
        Assert.That(testData[1], Is.EqualTo(1));
        Assert.That(testData[2], Is.EqualTo(2));
        Assert.That(testData[3], Is.EqualTo(3));
        Assert.That(testData[4], Is.EqualTo(4));
    }

    [Test]
    public void Mine_Test3()
    {
        var testData = new int[] { 1, 2 };

        var rd = new RemoveDuplicatesFromSortedArray();
        var r = rd.RemoveDuplicatesFromSortedArrayMine(testData);

        Assert.That(r, Is.EqualTo(2));
        Assert.That(testData[0], Is.EqualTo(1));
        Assert.That(testData[1], Is.EqualTo(2));
    }

    [Test]
    public void Mine_Test4()
    {
        var testData = new int[] { 1, 2, 3 };

        var rd = new RemoveDuplicatesFromSortedArray();
        var r = rd.RemoveDuplicatesFromSortedArrayMine(testData);

        Assert.That(r, Is.EqualTo(3));
        Assert.That(testData[0], Is.EqualTo(1));
        Assert.That(testData[1], Is.EqualTo(2));
        Assert.That(testData[2], Is.EqualTo(3));
    }
}