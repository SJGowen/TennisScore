using System;

namespace Tennis
{
    public class TennisGame
    {
        private string PlayerOneName { get; set; }

        private string PlayerTwoName { get; set; }

        private int PlayerOneScore { get; set; }

        private int PlayerTwoScore { get; set; }

        public string Score
        {
            get
            {
                if (PlayerOneScore + PlayerTwoScore < 6)
                {
                    if (PlayerOneScore != PlayerTwoScore)
                    {
                        if (PlayerOneScore == 4 || PlayerTwoScore == 4)
                        {
                            return $"Game {GetHighestPlayer()}";
                        }

                        return $"{GetTennisScore(PlayerOneScore)}-{GetTennisScore(PlayerTwoScore)}";
                    }
                    else
                    {
                        return $"{GetTennisScore(PlayerOneScore)} All";
                    }
                }
                else if (PlayerOneScore == PlayerTwoScore)
                {
                    return "Deuce";
                }
                else if (Math.Abs(PlayerOneScore - PlayerTwoScore) == 1)
                {
                    return $"Advantage {GetHighestPlayer()}";
                }
                return $"Game {GetHighestPlayer()}";
            }
        }

        private string GetHighestPlayer()
        {
            if (PlayerOneScore > PlayerTwoScore)
                return $"'{PlayerOneName}'";
            else
                return $"'{PlayerTwoName}'";
        }

        private string GetTennisScore(int score)
        {
            if (score == 0) return "Love";
            if (score == 1) return "Fifteen";
            if (score == 2) return "Thirty";
            if (score == 3) return "Forty";
            return "Error";
        }

        public TennisGame(string playerOne = null, string playerTwo = null)
        {
            PlayerOneName = string.IsNullOrEmpty(playerOne) ? "Player One" : playerOne;
            PlayerTwoName = string.IsNullOrEmpty(playerTwo) ? "Player Two" : playerTwo;
        }

        public void AwardPoint(bool playerOneScores)
        {
            if (playerOneScores)
            {
                PlayerOneScore++;
            }
            else
            {
                PlayerTwoScore++;
            }
        }
    }
}