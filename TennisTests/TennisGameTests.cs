using Xunit;

namespace Tennis
{
    public class TennisGameTests
    {
        private static void AwardPoints(int playerScore, TennisGame tennisGame, bool toPlayerOne)
        {
            for (int i = 0; i < playerScore; i++)
            {
                tennisGame.AwardPoint(toPlayerOne);
            }
        }

        [Fact]
        public void NewGameHasScoreLoveAll()
        {
            var tennisGame = new TennisGame();
            Assert.Equal("Love All", tennisGame.Score);
        }

        [Fact]
        public void AwardPointOnLoveMakesItEqualFifteen()
        {
            var tennisGame = new TennisGame();
            AwardPoints(1, tennisGame, true);
            Assert.Equal("Fifteen-Love", tennisGame.Score);
        }

        [Fact]
        public void AwardPointOnFifteenMakesItEqualThirty()
        {
            var tennisGame = new TennisGame();
            AwardPoints(2, tennisGame, true);
            Assert.Equal("Thirty-Love", tennisGame.Score);
        }

        [Fact]
        public void AwardPointOnThirtyMakesItEqualForty()
        {
            var tennisGame = new TennisGame();
            AwardPoints(3, tennisGame, true);
            Assert.Equal("Forty-Love", tennisGame.Score);
        }

        [Fact]
        public void AwardPointOnFortyMakesItEqualGame()
        {
            var tennisGame = new TennisGame();
            AwardPoints(4, tennisGame, true);
            Assert.Equal("Game 'Player One'", tennisGame.Score);
        }

        [Theory]
        [InlineData("Love All", 0, 0)]
        [InlineData("Fifteen All", 1, 1)]
        [InlineData("Thirty All", 2, 2)]
        [InlineData("Deuce", 3, 3)]
        [InlineData("Game 'Player One'", 4, 2)]
        [InlineData("Advantage 'Player One'", 4, 3)]
        [InlineData("Game 'Player One'", 5, 3)]
        [InlineData("Game 'Player Two'", 5, 7)]
        [InlineData("Advantage 'Player Two'", 6, 7)]
        [InlineData("Deuce", 8, 8)]
        public void GetTennisScore(string score, int playerOneScore, int playerTwoScore)
        {
            var tennisGame = new TennisGame();
            AwardPoints(playerOneScore, tennisGame, true);
            AwardPoints(playerTwoScore, tennisGame, false);

            Assert.Equal(score, tennisGame.Score);
        }

        [Theory]
        [InlineData("Game 'Borg'", 4, 0)]
        [InlineData("Game 'Borg'", 4, 1)]
        [InlineData("Advantage 'Borg'", 4, 3)]
        [InlineData("Game 'Borg'", 5, 3)]
        [InlineData("Game 'Agasi'", 5, 7)]
        [InlineData("Advantage 'Agasi'", 6, 7)]
        public void GetTennisScoreForNamedPlayers(string score, int playerOneScore, int playerTwoScore)
        {
            var tennisGame = new TennisGame("Borg", "Agasi");
            AwardPoints(playerOneScore, tennisGame, true);
            AwardPoints(playerTwoScore, tennisGame, false);

            Assert.Equal(score, tennisGame.Score);
        }
    }
}
