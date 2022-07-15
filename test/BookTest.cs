using System;
using Xunit;

namespace GradeBook.Tests;

public class BookTest
{
    [Fact]
    public void Test1()
    
    {
        // arrange
        var book = new Book(" ");
        book.addGrade(90.5);
        book.addGrade(50.6);
        book.addGrade(89.9);

        //act
        var result = book.getStatistic();

        //assert
        Assert.Equal(90.5,result.High);
        Assert.Equal(50.6,result.Low);
        Assert.Equal(77.0,result.Average);
    }    
}