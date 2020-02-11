using Xunit;

namespace Tennis
{
    public class TennisGameTests
    {
        [Fact]
        public void NewGameHasScoreLoveLove()
        {
            var tennisGame = new TennisGame();
            Assert.Equal("Love-Love", tennisGame.Score());
        }
    }
}
