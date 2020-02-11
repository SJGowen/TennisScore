using System;

namespace Tennis
{
    public class TennisGame
    {
        private int PlayerOneScore { get; set; }
         
        private int PlayerTwoScore { get; set; }

        public string Score
        {
            get { return $"{GetTennisScore(PlayerOneScore)}-{GetTennisScore(PlayerTwoScore)}"; }
        }

        private string GetTennisScore(int score)
        {
            if (score == 0) return "Love";
            if (score == 1) return "Fifteen";
            if (score == 2) return "Thirty";
            if (score == 3) return "Forty";
            return "Error";
        }

        public TennisGame()
        {
        }

        public void AwardPoint()
        {
            PlayerOneScore++;
        }
    }
}