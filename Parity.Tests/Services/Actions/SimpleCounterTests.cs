using NUnit.Framework;
using ParityBitCount.Services.Actions;

namespace ParityBitCount.Tests.Services.Actions
{
    [TestFixture]
    public class SimpleCounterTests
    {
        private ISimpleCounter<object> Subject;

        [SetUp]
        public void Setup()
        {
            Subject = new SimpleCounter<object>();
        }
        
        [Test]
        public void When_RequestingCounterToCount_ItActuallyCounts()
        {
            var counter = 100;
            
            for (var i= 0;i<counter;i++){
                Subject.Count(null);
            }

            Assert.AreEqual(counter, Subject.Counter);
        }

         [Test]
        public void When_NoCountsOccured_ResultIsZero()
        {
            Assert.AreEqual(0, Subject.Counter);
        }
    }
}