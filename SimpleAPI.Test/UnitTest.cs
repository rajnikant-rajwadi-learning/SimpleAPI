using System;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest
    {
        WeatherForecastController controller;


        public UnitTest()
        {
            controller = new WeatherForecastController();
        }

        [Fact]
        public void GetReturnsByName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Rajnikant Rajwadi1", returnValue.Value);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
