namespace leetCode.Tests;

[TestFixture]
public class MajorityElementTests
{
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
}