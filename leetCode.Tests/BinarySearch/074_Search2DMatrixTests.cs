using System;
using leetCode.BinarySearch;

namespace leetCode.Tests.BinarySearch;

public class Search2DMatrixTests
{
    [Test]
    public void Mine_Test1()
    {
        var sm = new Search2DMatrix();
        var matrix = new int[][]
        {
            new int[] {1, 3, 5, 7},
            new int[] {10, 11, 16, 20},
            new int[] {23, 30, 34, 60}
        };
        var target = 3;
        var retVal = sm.SearchMatrix(matrix, target);
        Assert.That(retVal, Is.True);
    }

    [Test]
    public void Mine_Test2()
    {
        var sm = new Search2DMatrix();
        var matrix = new int[][]
        {
            new int[] {1, 3, 5, 7},
            new int[] {10, 11, 16, 20},
            new int[] {23, 30, 34, 60}
        };
        var target = 13;
        var retVal = sm.SearchMatrix(matrix, target);
        Assert.That(retVal, Is.False);        
    }
}
