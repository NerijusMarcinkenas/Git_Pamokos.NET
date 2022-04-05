using NUnit.Framework;
using StrukturosIrUnitTestai;
namespace Task2_Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingTask2()
        {

            //1. Arranage (Duomenu mock)

            double expectedResult = 100;
            double length = 10;
            double width = 10;

            //2. Act (call method)
         
            Rectangle getArea = new Rectangle();

            double actualResult = getArea.GetArea(length, width);

            //3. Assert (Lyginam)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}