using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test;

public class UnitTest1
{

    WeatherForecastController controller = new WeatherForecastController();

    [Fact]
    public void TestSum()
    {

        var returnValue = controller.Sum(3,4);
        Assert.Equal(7,returnValue);

    }

    [Fact]
    public void Test1()
    {

    }
}