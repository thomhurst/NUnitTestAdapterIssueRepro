using NUnit.Framework;

namespace NUnitTestAdapterIssueRepro
{
    [SetUpFixture]
    public class SetupFixture
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
        }

        [OneTimeTearDown]
        public void OneTimeTeardown()
        {
        }
    }
}