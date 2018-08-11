using NUnit.Framework;
using ParityBitCount.Solution;

namespace Parity.Tests.Controller
{
    [TestFixture]
    public class SuperGenericParitySolutionTests : BaseParitySolutionTests
    {
        public SuperGenericParitySolutionTests() : base(new SuperGenericParitySolution())
        {
        }

         [Test]
        public override void When_RunningBasicSolution_WithTestCases_ResultsAreCorrect()
        {
            base.When_RunningBasicSolution_WithTestCases_ResultsAreCorrect();
        }
    }
}