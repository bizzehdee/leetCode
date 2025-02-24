namespace leetCode.Tests;

[TestFixture]
public class Tests
{
    [Test]
    public void Dotnet_Test1()
    {
        var msa = new MergeSortedArray();

        var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new[] { 2, 5, 6 };
        var m = 3;
        var n = 3;

        msa.MergeDotnet(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(new[] { 1, 2, 2, 3, 5, 6 }));
    }

    [Test]
    public void Dotnet_Test2()
    {
        var msa = new MergeSortedArray();

        var nums1 = new[] { 1 };
        var nums2 = Array.Empty<int>();
        var m = 1;
        var n = 0;

        msa.MergeDotnet(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(new[] { 1 }));
    }


    [Test]
    public void Dotnet_Test3()
    {
        var msa = new MergeSortedArray();

        var nums1 = new[] { 0 };
        var nums2 = new[] { 1 };
        var m = 0;
        var n = 1;

        msa.MergeDotnet(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(new[] { 1 }));
    }
    
        [Test]
    public void Mine_Test1()
    {
        var msa = new MergeSortedArray();

        var nums1 = new[] { 1, 2, 3, 0, 0, 0 };
        var nums2 = new[] { 2, 5, 6 };
        var m = 3;
        var n = 3;

        msa.MergeMine(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(new[] { 1, 2, 2, 3, 5, 6 }));
    }

    [Test]
    public void Mine_Test2()
    {
        var msa = new MergeSortedArray();

        var nums1 = new[] { 1 };
        var nums2 = Array.Empty<int>();
        var m = 1;
        var n = 0;

        msa.MergeMine(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(new[] { 1 }));
    }
    
    
    [Test]
    public void Mine_Test3()
    {
        var msa = new MergeSortedArray();

        var nums1 = new[] { 0 };
        var nums2 = new[] { 1 };
        var m = 0;
        var n = 1;

        msa.MergeMine(nums1, m, nums2, n);

        Assert.That(nums1, Is.EqualTo(new[] { 1 }));
    }
}