using leetCode.Backtracking;

namespace leetCode.Tests.BacktrackingTests;

public class LetterCombinationsOfAPhoneNumberTests
{
    [Test]
    public void Mine_Test1()
    {
        var lcpn = new LetterCombinationsOfAPhoneNumber();
        var digits = "23";
        var result = lcpn.LetterCombinations(digits);
        Assert.That(result, Contains.Item("ad"));
        Assert.That(result, Contains.Item("ae"));
        Assert.That(result, Contains.Item("af"));
        Assert.That(result, Contains.Item("bd"));
        Assert.That(result, Contains.Item("be"));
        Assert.That(result, Contains.Item("bf"));
        Assert.That(result, Contains.Item("cd"));
        Assert.That(result, Contains.Item("ce"));
        Assert.That(result, Contains.Item("cf"));
    }
    
    [Test]
    public void Mine_Test2()
    {
        var lcpn = new LetterCombinationsOfAPhoneNumber();
        var digits = "";
        var result = lcpn.LetterCombinations(digits);
        Assert.That(result, Is.Empty);
    }
    
    
    [Test]
    public void Mine_Test3()
    {
        var lcpn = new LetterCombinationsOfAPhoneNumber();
        var digits = "2";
        var result = lcpn.LetterCombinations(digits);
        Assert.That(result, Contains.Item("a"));
        Assert.That(result, Contains.Item("b"));
        Assert.That(result, Contains.Item("c"));
    }
}
