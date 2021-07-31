using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        WeatherForecastController wController = new WeatherForecastController();  //Arrange
        [Fact]
        public void Test1()
        {
           var output= wController.FetchData(1); //Act
            Assert.Equal("Tarun Sachdeva",output); //Assert
        }
    }
}
