using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustScored
{
    public class PlayerInfo
    {
        private float maxScore;
        private int gamesPlayed;
        private int gamesWon;

        public float MaxScore
        {
            get
            {
                return maxScore;
            }
            set
            {
                if (value > maxScore)
                {
                    maxScore = value;
                }
            }
        }


    }
}