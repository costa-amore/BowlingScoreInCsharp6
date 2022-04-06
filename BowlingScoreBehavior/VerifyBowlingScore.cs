using BowlingScore;
using NUnit.Framework;

namespace BowlingScoreBehavior
{
    public class VerifyBowlingScore
    {


        #region templates
        [Test]        
        public void Test1()
        {
            Assert.That(new Something(false).CanFly, Is.EqualTo(true));
        }

        [TestCase(false)]        
        [TestCase(true)]        
        public void Test2(bool flightCapable)
        {
            Assert.That(new Something(flightCapable).CanFly, Is.EqualTo(true));
        }
        #endregion
    }
}