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

        public string Name{ get; }

        public float RateOfSuccess
        {
            get
            {
                if (gamesPlayed == 0)
                {
                    return 0;
                }

                else
                {
                    return gamesWon / gamesPlayed;
                }
            }
        }

        public void AddGame(bool win)
        {
            gamesPlayed++;
            if (win)
            {
                gamesWon++;
            }
        }


        public PlayerInfo(string name)
        {
            this.Name = name;
            gamesPlayed = 0;
            gamesWon = 0;
            maxScore = 0;
        }
    }
}