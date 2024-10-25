using Problemas;
using System.Collections;

namespace TestProject
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(new int[][] { new int[] { 1, 2, 3 } }, 0);
                yield return new TestCaseData(new int[][] { new int[] { 1, 5, 6 } }, 1);
                // Add more test cases as needed
            }
        }

        [Test, TestCaseSource(nameof(TestCases))]
        public void Test1(int[][] n, int output)
        {
            Assert.AreEqual(ClaseProblemas.problema1(n[0][0]), output);
        }
    }
}