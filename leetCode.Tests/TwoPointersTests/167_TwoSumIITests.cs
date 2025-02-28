using System;
using leetCode.TwoPointers;

namespace leetCode.Tests.TwoPointersTests;

public class TwoSumIITests
{
    [Test]
    public void Mine_Test1()
    {
        var ts = new TwoSumII();

        var retVal = ts.TwoSumMine(new int[] { 2, 7, 11, 15 }, 9);
        Assert.That(retVal, Is.EqualTo(new int[] { 1, 2 }));
    }

    [Test]
    public void Mine_Test2()
    {
        var ts = new TwoSumII();

        var retVal = ts.TwoSumMine(new int[] { 2,3,4 }, 6);
        Assert.That(retVal, Is.EqualTo(new int[] { 1, 3 }));
    }
    
    [Test]
    public void Mine_Test3()
    {
        var ts = new TwoSumII();
        
        var retVal = ts.TwoSumMine(new int[] { -1, 0 }, -1);
        Assert.That(retVal, Is.EqualTo(new int[] { 1, 2 }));
    }
}
