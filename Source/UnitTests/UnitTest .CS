using NUnit.Framework;

namespace ImpDivBy7
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            const int input = 70;
            const int answer = 10;
           
           Assert.AreEqual(input/7, answer);
        }
    }
}
