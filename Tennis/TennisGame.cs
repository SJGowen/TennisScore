using System;

namespace Tennis
{
    public class TennisGame
    {
        public int PlayerOneScore { get; set; }
         
        public int PlayerTwoScore { get; set; }

        public string Score
        {
            get { return $"{GetTennisScore(PlayerOneScore)}-{GetTennisScore(PlayerTwoScore)}"; }
        }

        private string GetTennisScore(int score)
        {
            if (score == 0) return "Love";
            if (score == 1) return "Fifteen";
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