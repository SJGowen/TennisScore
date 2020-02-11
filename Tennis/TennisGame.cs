using System;

namespace Tennis
{
    public class TennisGame
    {
        public string Score { get; set; }

        public TennisGame()
        {
            Score = "Love-Love";
        }

        public void AwardPoint()
        {
            throw new NotImplementedException();
        }
    }
}