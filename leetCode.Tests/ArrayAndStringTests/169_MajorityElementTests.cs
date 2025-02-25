using leetCode.ArrayAndString;

namespace leetCode.Tests.ArrayAndStringTests;

[TestFixture]
public class MajorityElementTests
{
    [Test]
    public void Dotnet_Test1()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementDotnet(new int[] { 3, 2, 3 });
        Assert.That(retVal, Is.EqualTo(3));
    }

    [Test]
    public void Dotnet_Test2()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementDotnet(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        Assert.That(retVal, Is.EqualTo(2));
    }

    [Test]
    public void Dotnet_Test3()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementDotnet(new int[] { 1 });
        Assert.That(retVal, Is.EqualTo(1));
    }

    [Test]
    public void Dotnet_Test4()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementDotnet(new int[] { 6, 5, 5 });
        Assert.That(retVal, Is.EqualTo(5));
    }

    [Test]
    public void Mine_Test1()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementMine(new int[] { 3, 2, 3 });
        Assert.That(retVal, Is.EqualTo(3));
    }

    [Test]
    public void Mine_Test2()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementMine(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        Assert.That(retVal, Is.EqualTo(2));
    }

    [Test]
    public void Mine_Test3()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementMine(new int[] { 1 });
        Assert.That(retVal, Is.EqualTo(1));
    }

    [Test]
    public void Mine_Test4()
    {
        var me = new MajorityElement();
        var retVal = me.MajorityElementMine(new int[] { 6, 5, 5 });
        Assert.That(retVal, Is.EqualTo(5));
    }
}