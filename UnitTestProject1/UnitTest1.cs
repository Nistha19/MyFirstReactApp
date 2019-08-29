using Microsoft.VisualStudio.TestTools.UnitTesting;

using static MyFirstReactApp.Controllers.SampleDataController;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 76;

            WeatherForecast weatherObj = new WeatherForecast
            {
                TemperatureC = 25
            };
            int actual = weatherObj.TemperatureF;

            //Assert
            Assert.AreEqual(expected, actual, "Temperature Conversion Failed-1");


        }
    }
}

