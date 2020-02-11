using Xunit;

namespace Tennis
{
    public class TennisGameTests
    {
        [Fact]
        public void NewGameHasScoreLoveLove()
        {
            var tennisGame = new TennisGame();
            Assert.Equal("Love-Love", tennisGame.Score);
        }

        [Fact]
        public void AwardPointOnLoveMakesItEqualFifteen()
        {
            var tennisGame = new TennisGame();
            tennisGame.AwardPoint();
            Assert.Equal("Fifteen-Love", tennisGame.Score);
        }

        [Fact]
        public void AwardPointOnFifteenMakesItEqualThirty()
        {
            var tennisGame = new TennisGame();
            tennisGame.AwardPoint();
            tennisGame.AwardPoint();
            Assert.Equal("Thirty-Love", tennisGame.Score);
        }

        [Fact]
        public void AwardPointOnThirtyMakesItEqualForty()
        {
            var tennisGame = new TennisGame();
            tennisGame.AwardPoint();
            tennisGame.AwardPoint();
            tennisGame.AwardPoint();
            Assert.Equal("Forty-Love", tennisGame.Score);
        }
    }
}
