using NUnit.Framework;
using StrukturosIrUnitTestai;

namespace Testas
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestingTaxCalculator()
        {
            // Arranage (Duomenu mock)
            decimal income = 10000m;
            decimal expectedResult = 500m;
            // Act (call method)
            decimal actualResult = Program.CalculateTax(income);
            // Assert (Lyginam)
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}