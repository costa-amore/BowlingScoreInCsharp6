BowlingScore Kata
-------------------

introduction to Test/Behavior Driven Development

Find Kata guidance here : https://docs.google.com/presentation/d/1oyKAP6_XVzAcWc8iGe6tqxh2q91jx-Lz0mvOg4WqTs4/edit?usp=sharing


Suggested shortcuts (VS 2022)
.............................

 - run all tests : CTRL R, A
 - commit        : ALT   , G     , C
 - rename        : CTRL R, CTRL R
 - Extract Method: CTRL R, CTRL M


Suggested Test body structures 
...............................

        #region templates
        [Test]        
        public void Test1()
        {
            Assert.That(new Something().CanFly, Is.EqualTo(true));
        }

        [TestCase(false)]        
        [TestCase(true)]        
        public void Test2(bool flightCapable)
        {
            Assert.That(new Something(flightCapable).CanFly, Is.EqualTo(true));
        }
        #endregion


