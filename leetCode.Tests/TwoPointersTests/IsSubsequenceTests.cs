using System;
using leetCode.TwoPointers;

namespace leetCode.Tests.TwoPointersTests;

[TestFixture]
public class IsSubsequenceTests
{
    [Test]
    public void Mine_Test1()
    {
        var iss = new IsSubsequence();
        var retVal = iss.IsSubsequenceMine("abc", "ahbgdc");
        Assert.That(retVal, Is.True);
    }

    [Test]
    public void Mine_Test2()
    {
        var iss = new IsSubsequence();
        var retVal = iss.IsSubsequenceMine("axc", "ahbgdc");
        Assert.That(retVal, Is.False);
    }

    [Test]
    public void Mine_Test3()
    {
        var iss = new IsSubsequence();
        var retVal = iss.IsSubsequenceMine("acb", "ahbgdc");
        Assert.That(retVal, Is.False);
    }
    
    [Test]
    public void Mine_Test4()
    {
        var iss = new IsSubsequence();
        var retVal = iss.IsSubsequenceMine("aaaaaa", "bbaaaa");
        Assert.That(retVal, Is.False);
    }
}
