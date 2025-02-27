using leetCode.TwoPointers;

namespace leetCode.Tests.TwoPointersTests;

public class ValidPalindromeTests
{

    [Test]
    public void Mine_Test1()
    {
        var vp = new ValidPalindrome();
        var retVal = vp.IsPalindrome("A man, a plan, a canal: Panama");
        Assert.That(retVal, Is.True);
    }

    [Test]
    public void Mine_Test2()
    {
        var vp = new ValidPalindrome();
        var retVal = vp.IsPalindrome("race a car");
        Assert.That(retVal, Is.False);
    }

    [Test]
    public void Mine_Test3()
    {
        var vp = new ValidPalindrome();
        var retVal = vp.IsPalindrome(" ");
        Assert.That(retVal, Is.True);
    }

    [Test]
    public void Mine_Test4()
    {
        var vp = new ValidPalindrome();
        var retVal = vp.IsPalindrome("0P");
        Assert.That(retVal, Is.False);
    }
}

