using Problemas;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0,0)]
        public void Test1(int n, int output)
        {
            Assert.AreEqual(ClaseProblemas.problema1(n), output);
        }
    }
}