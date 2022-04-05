using NUnit.Framework;
using StrukturosIrUnitTestai;
using System;

namespace Task3_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Task3GetAreaTest()
        {
            // Arranage (Duomenu mock)
            double length = 10d;
            double width = 10d;
            double expectedResult = 100d;
            // Act (call method)
            Rectangle getArea = new Rectangle();
            double actualResult = getArea.GetArea(length, width);
                
            // Assert (Lyginam)
            Assert.AreEqual(expectedResult, actualResult);
        }

        public void Task2GetDaysTest()
        {
            // arrange

            //DateTime today = DateTime.Now.Date;
            //DateTime dateTaken = new DateTime(2022, 03, 04).Date;
            //TimeSpan expectedResult = Date;

                


        }
    }
}