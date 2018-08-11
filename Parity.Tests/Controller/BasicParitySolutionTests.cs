using NUnit.Framework;
using ParityBitCount.Solution;

namespace Parity.Tests.Controller
{
    [TestFixture]
    public class BasicParitySolutionTests : BaseParitySolutionTests
    {
        public BasicParitySolutionTests() : base(new BasicParitySolution())
        {
        }

        [Test]
        public override void When_RunningBasicSolution_WithTestCases_ResultsAreCorrect()
        {
            base.When_RunningBasicSolution_WithTestCases_ResultsAreCorrect();
        }
    }
}