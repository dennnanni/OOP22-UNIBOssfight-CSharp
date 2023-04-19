using System;
using System.Collections.Generic;
using System.Linq;

namespace Nanni_Denise
{
    /// <summary>
    /// This class implements the logic of the score.
    /// </summary>
    public class Score
    {
        private const int KillScore = 2;
        private const int MaximumGrade = 110;
        private const int EnemyCount = 10;
        private const int CoinsCount = 16;
        private const int LevelCount = 2;

        private Dictionary<int, KeyValuePair<int, int>> _levelStats;

        /// <summary>
        /// Creates an instance of class Score.
        /// </summary>
        public Score()
        {
            _levelStats = new Dictionary<int, KeyValuePair<int, int>>();
        }

        /// <summary>
        /// Indexes the internal dictionary.
        /// </summary>
        /// <param name="key">an int representing level number</param>
        /// <returns>a key value pair with enemies count as key and
        /// coins count as value</returns>
        public KeyValuePair<int, int> this[int key]
        {
            get => _levelStats[key];

            set => _levelStats[key] = value;
        }

        /// <summary>
        /// Property to get earned points in all levels.
        /// </summary>
        public int EarnedPoints
        {
            get => _levelStats.Values.Select(x => x.Key * KillScore + x.Value)
                .Sum(x => x);
        }

        /// <summary>
        /// Property to get total points of each level.
        /// </summary>
        public int TotalPoints
        {
            get => EnemyCount * KillScore + CoinsCount;
        }

        /// <summary>
        /// Property to get the final grade from the earned points.
        /// </summary>
        public int FinalGrade
        {
            get => MaximumGrade * EarnedPoints / (TotalPoints / LevelCount);
        }
    }
}
