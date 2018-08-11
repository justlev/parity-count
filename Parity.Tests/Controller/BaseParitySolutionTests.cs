using System.Collections.Generic;
using NUnit.Framework;
using ParityBitCount.Solution;

namespace Parity.Tests.Controller
{
    public class BaseParitySolutionTests
    {
        private Dictionary<int, int> _testCases = new Dictionary<int, int>();
        private IParitySolution Subject;

        public BaseParitySolutionTests(IParitySolution subject)
        {
            Subject = subject;
        }

        [SetUp]
        public void SetUp()
        {
            _testCases.Add(5,2);
            _testCases.Add(0,0);
            _testCases.Add(8,1);
            _testCases.Add(15,4);
            _testCases.Add(19,3);
            _testCases.Add(1000000,7);
        }

        public virtual void When_RunningBasicSolution_WithTestCases_ResultsAreCorrect()
        {
            if (Subject == null) return;
            foreach (var testCase in _testCases)
            {
                System.Console.WriteLine("Test Case - for input {0} Expected {1}", testCase.Key, testCase.Value);
                Assert.AreEqual(testCase.Value, Subject.GetParity(testCase.Key));
            }
        }
    }
}