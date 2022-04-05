using NUnit.Framework;
using StrukturosIrUnitTestai;

namespace OddOrEvenTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           
            int number = 10;

            bool actualResult = Program.OddOrEven(number);


            Assert.IsTrue(actualResult);
        }
    }
}