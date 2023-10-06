using CSESProblemSet.Introductory.Problems;

using Xunit;
using Xunit.Abstractions;

namespace CSESProblemSetTests.Introductory.Problems
{
    public class IntroductoryProblemsTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        public IntroductoryProblemsTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Theory]
        [InlineData(4, 5, new int[] { 2, 3, 1, 5 })]
        [InlineData(1, 2, new int[] { 2 })]
        [InlineData(2, 4, new int[] { 3, 1, 4 })]
        [InlineData(2, 3, new int[] { 3, 1 })]
        public void MissingNumber_Tests(int expected, int n, int[] arr)
        {
            _testOutputHelper.WriteLine($"n: {n}, arr: {string.Join(",", arr)}");
            Assert.Equal(expected, MissingNumber.Solve(n, arr));
        }

        [Theory]
        [InlineData(1, "A")]
        [InlineData(2, "AA")]
        [InlineData(3, "AAA")]
        [InlineData(3, "AAAC")]
        [InlineData(3, "AAACC")]
        [InlineData(3, "AAACCC")]
        [InlineData(4, "AAACCCC")]
        [InlineData(5, "CCCCCAAA")]
        public void Repetitions_Tests(int expected, string s)
        {
            _testOutputHelper.WriteLine($"s: {s}");
            Assert.Equal(expected, Repetitions.Solve(s));
        }

        [Theory]
        [InlineData(4, "AAAACCCGGT")]
        [InlineData(2, "CTCAGGTCCG")]
        [InlineData(4, "ACCGGGTTTT")]
        public void SolveLongestRepition_Tests(int expected, string s)
        {
            _testOutputHelper.WriteLine($"s: {s}");
            Assert.Equal(expected, Repetitions.SolveLongestRepition(s));
        }
    }

}