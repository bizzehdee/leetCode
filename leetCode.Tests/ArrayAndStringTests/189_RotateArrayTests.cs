using System;
using leetCode.ArrayAndString;

namespace leetCode.Tests.ArrayAndStringTests;


[TestFixture]
public class RotateArrayTests
{
    [Test]
    public void Mine_Test1()
    {
        var ra = new RotateArray();
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        ra.RotateMine(nums, 3);
        Assert.That(nums, Is.EqualTo(new int[] { 5, 6, 7, 1, 2, 3, 4 }));
    }

    [Test]
    public void Mine_Test2()
    {
        var ra = new RotateArray();
        var nums = new int[] { -1, -100, 3, 99};
        ra.RotateMine(nums, 2);
        Assert.That(nums, Is.EqualTo(new int[] { 3,99,-1,-100 }));
    }

    [Test]
    public void Mine_Test3()
    {
        var ra = new RotateArray();
        var nums = new int[] { -1 };
        ra.RotateMine(nums, 2);
        Assert.That(nums, Is.EqualTo(new int[] { -1 }));
    }
}
