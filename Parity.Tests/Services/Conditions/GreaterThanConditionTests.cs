using NUnit.Framework;
using ParityBitCount.Services.Conditions;

namespace ParityBitCount.Tests.Services.Conditions
{
    [TestFixture]
    public class GreaterThanConditionTests
    {
        private ICondition<int> Subject;

        [SetUp]
        public void SetUp()
        {
            Subject = new GreaterThanCondition<int>(2);
        }

        [Test]
        public void When_ActualNumber_IsGreaterThanExpected_ConditionReturnsTrue()
        {
            Assert.IsTrue(Subject.Applies(3));
        }

        [Test]
        public void When_ActualNumber_IsSmallerThanExpected_ConditionReturnsFalse()
        {
            Assert.IsFalse(Subject.Applies(1));
        }

        [Test]
        public void When_ActualNumber_IsEqualToExpected_ConditionReturnsFalse()
        {
            Assert.IsFalse(Subject.Applies(0));
        }
    }
}