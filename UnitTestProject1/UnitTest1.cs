using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static MyFirstReactApp.Controllers.SampleDataController;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

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
        
     
        [TestMethod]
        public void TestMethod2()

        {
            var expectedTemp = TestContext.Properties["fahrenheitTemp"].ToString();
            var ctemp =  TestContext.Properties["celsiusTemp"].ToString();

            WeatherForecast weatherObj = new WeatherForecast
            {
                TemperatureC = System.Int32.Parse(ctemp)
            };
            int actual = weatherObj.TemperatureF;

            //Assert
            Assert.AreEqual(System.Int32.Parse(expectedTemp), actual, "Temperature Conversion Failed-2");

        }

       
    }
}

