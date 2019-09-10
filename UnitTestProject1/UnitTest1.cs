using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static MyFirstReactApp.Controllers.SampleDataController;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /*
        public static int celsiusTemperature = 0;
        [ClassInitialize]
        public static void TestClassInitialize(TestContext context)
        {
            var celsiusTemperature = Convert.ToInt32(context.Properties["celsiusTemp"]);
            
            Console.WriteLine(celsiusTemperature);
        }
        */
        

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
        
     
        [DataTestMethod]
        [DataRow(25)]
        public void TestMethod2(int temp)

        {
            int expectedTemp = 76;

            WeatherForecast weatherObj = new WeatherForecast
            {
                TemperatureC = temp
            };
            int actual = weatherObj.TemperatureF;

            //Assert
            Assert.AreEqual(expectedTemp, actual, "Temperature Conversion Failed-2");

        }

    }
}

