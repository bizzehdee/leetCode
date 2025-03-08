using System;
using leetCode.ArrayAndString;

namespace leetCode.Tests.ArrayAndStringTests;

public class BestTimeToBuyAndSellStockTests
{
    [Test]
    public void Mine_Test1()
    {
        var me = new BestTimeToBuyAndSellStock();
        var retVal = me.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        Assert.That(retVal, Is.EqualTo(5));
    }

    [Test]
    public void Mine_Test2()
    {
        var me = new BestTimeToBuyAndSellStock();
        var retVal = me.MaxProfit(new int[] { 7,6,4,3,1 });
        Assert.That(retVal, Is.EqualTo(0));
    }
}
