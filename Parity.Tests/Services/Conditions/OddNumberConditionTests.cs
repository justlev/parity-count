using NUnit.Framework;
using ParityBitCount.Services.Conditions;

namespace ParityBitCount.Tests.Services.Conditions
{
    [TestFixture]
    public class OddNumberConditionTests
    {
        private ICondition<int> Subject;

        [SetUp]
        public void SetUp()
        {
            Subject = new OddNumberCondition();
        }

        [Test]
        public void When_ActualNumber_IsOdd_ConditionReturnsTrue()
        {
            Assert.IsTrue(Subject.Applies(3));
        }

        [Test]
        public void When_ActualNumber_IsEven_ConditionReturnsFalse()
        {
            Assert.IsFalse(Subject.Applies(2));
        }
    }
}