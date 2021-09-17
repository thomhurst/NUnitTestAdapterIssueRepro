using NUnit.Framework;

namespace NUnitTestAdapterIssueRepro
{
    [TestFixture(1)]
    [TestFixture(2)]
    [TestFixture(3)]
    public class Tests
    {
        public Tests(int n)
        {
        }
        
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}