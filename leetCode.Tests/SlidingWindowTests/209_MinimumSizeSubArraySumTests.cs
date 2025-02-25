using System;
using leetCode.SlidingWindow;

namespace leetCode.Tests.SlidingWindowTests;

[TestFixture]
public class MinimumSizeSubArraySumTests
{
    [Test]
    public void Mine_Test1()
    {
        var ms = new MinimumSizeSubArraySum();
        var retVal = ms.MinSubArrayLen(7, new int[] {2,3,1,2,4,3});
        Assert.That(retVal, Is.EqualTo(2));
    }

    [Test]
    public void Mine_Test2()
    {
        var ms = new MinimumSizeSubArraySum();
        var retVal = ms.MinSubArrayLen(4, new int[] {1,4,4});
        Assert.That(retVal, Is.EqualTo(1));
    }

    [Test]
    public void Mine_Test3()
    {
        var ms = new MinimumSizeSubArraySum();
        var retVal = ms.MinSubArrayLen(11, new int[] {1,1,1,1,1,1,1,1});
        Assert.That(retVal, Is.EqualTo(0));
    }

    [Test]
    public void Mine_Test4()
    {
        var ms = new MinimumSizeSubArraySum();
        var retVal = ms.MinSubArrayLen(11, new int[] {1,2,3,4,5});
        Assert.That(retVal, Is.EqualTo(3));
    }
}
