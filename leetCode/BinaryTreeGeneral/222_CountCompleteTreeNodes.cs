using System;

namespace leetCode.BinaryTreeGeneral;

//provided by leetCode
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

/// <summary>
/// https://leetcode.com/problems/count-complete-tree-nodes/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class CountCompleteTreeNodes
{
    public int CountNodes(TreeNode root)
    {
        //null root, dont bother
        if (root == null) return 0;

        //count ourselves
        var count = 1;
        //add in the left subtree count
        count += CountNodes(root.left);
        //add in the right subtree count
        count += CountNodes(root.right);
        
        return count;
    }
}
