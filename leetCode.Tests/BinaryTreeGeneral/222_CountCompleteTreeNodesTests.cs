using System;
using leetCode.BinaryTreeGeneral;

namespace leetCode.Tests.BinaryTreeGeneral;

public class CountCompleteTreeNodesTests
{
    [Test]
    public void Mine_Test1()
    {
        var ct = new CountCompleteTreeNodes();
        var root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6)));
        var retVal = ct.CountNodes(root);
        Assert.That(retVal, Is.EqualTo(6));
    }

    [Test]
    public void Mine_Test2()
    {
        var ct = new CountCompleteTreeNodes();
        var root = (TreeNode)null; 
        var retVal = ct.CountNodes(root);
        Assert.That(retVal, Is.EqualTo(0));
    }

    [Test]
    public void Mine_Test3()
    {
        var ct = new CountCompleteTreeNodes();
        var root = new TreeNode(1);
        var retVal = ct.CountNodes(root);
        Assert.That(retVal, Is.EqualTo(1));
    }
}
