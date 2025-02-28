using System;
using leetCode.BinarySearch;

namespace leetCode.Tests.BinarySearch;

public class FindPeakElementTests
{
    [Test]
    public void Mine_Test1()
    {
        var fpe = new FindPeakElement();
        var nums = new int[] {1, 2, 3, 1};
        var retVal = fpe.FindPeakElementMine(nums);
        Assert.That(retVal, Is.EqualTo(2));
    }

    [Test]
    public void Mine_Test2()
    {
        var fpe = new FindPeakElement();
        var nums = new int[] {1, 2, 1, 3, 5, 6, 4};
        var retVal = fpe.FindPeakElementMine(nums);
        Assert.That(retVal, Is.EqualTo(5));
    }

    [Test]
    public void Mine_Test3()
    {
        var fpe = new FindPeakElement();
        var nums = new int[] {-2147483648,-2147483647};
        var retVal = fpe.FindPeakElementMine(nums);
        Assert.That(retVal, Is.EqualTo(1));
    }
}
