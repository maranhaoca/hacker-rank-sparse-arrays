using System.Collections.Generic;
using Xunit;
using Src;

namespace Tests;

public class ResultTest
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var strings = new List<string>(){"ab", "ab", "abc"};
        var queries = new List<string>(){"ab", "abc", "bc"};

        var expected = new List<int>(){2, 1, 0};

        //Act
        var actual = Result.matchingStrings(strings, queries);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        //Arrange
        var strings = new List<string>(){"aba", "baba", "aba", "xzxb"};
        var queries = new List<string>(){"aba", "xzxb", "ab"};

        var expected = new List<int>(){2, 1, 0};

        //Act
        var actual = Result.matchingStrings(strings, queries);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test3()
    {
        //Arrange
        var strings = new List<string>(){"def", "de", "fgh"};
        var queries = new List<string>(){"de", "lmn", "fgh"};

        var expected = new List<int>(){1, 0, 1};

        //Act
        var actual = Result.matchingStrings(strings, queries);

        //Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test4()
    {
        //Arrange
        var strings = new List<string>(){"abcde", "sdaklfj", "asdjf", "na", "basdn", "sdaklfj", "asdjf", "na", "asdjf", "na", "basdn", "sdaklfj", "asdjf",};
        var queries = new List<string>(){"abcde", "sdaklfj", "asdjf", "na", "basdn"};

        var expected = new List<int>(){1, 3, 4, 3, 2};

        //Act
        var actual = Result.matchingStrings(strings, queries);

        //Assert
        Assert.Equal(expected, actual);
    }
}