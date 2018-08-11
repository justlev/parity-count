using NUnit.Framework;
using ParityBitCount.Services.IteratorMutators;

namespace ParityBitCount.Tests.Services.IteratorMutators
{
    [TestFixture]
    public class NumericMutatorTests
    {
        private IIteratorMutator<int> Subject;

        [SetUp]
        public void SetUp()
        {
            Subject = new NumericMutator(4);
        }

        [Test]
        public void When_ApplyingMutator_ItMutatesNumberCorrectly()
        {
            Assert.AreEqual(2, Subject.Mutate(8));
        }

        [Test]
        public void When_ApplyingMutator_WithoutDivideBy_ItMutatesNumber_ByTwo()
        {
            Subject = new NumericMutator();
            Assert.AreEqual(4, Subject.Mutate(8));
        }
    }
}