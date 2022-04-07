using BowlingScore;
using NUnit.Framework;

namespace BowlingScoreBehavior
{
    public class VerifyBowlingScore
    {
        [Test]
        public void testGutterGameScoreShouldBeZero(){
            Assert.That(calculateBowlingGame(0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0), Is.EqualTo(0));
        }

        [Test]
        public void testAllOnesGameScoreShouldBeTwenty(){
            Assert.That(calculateBowlingGame(1,1,1,1,1
                                            ,1,1,1,1,1
                                            ,1,1,1,1,1
                                            ,1,1,1,1,1), Is.EqualTo(20));
        }

        private int calculateBowlingGame(int v1, int v2, int v3, int v4, int v5, int v6, int v7, int v8, int v9, int v10, int v11, int v12, int v13, int v14, int v15, int v16, int v17, int v18, int v19, int v20)
        {
            return v1+v2+v3+v4+v5+v6+v7+v8+v9+v10+v11+v12+v13+v14+v15+v16+v17+v18+v19+v20;
        }
    }
    
}