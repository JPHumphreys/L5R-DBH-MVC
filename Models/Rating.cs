using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L5R_DBH_MVC.Models
{
    public class Rating
    {
        public string Id { get; set; }

        public float OverallRating { get; set; }

        public float CrabRating { get; set; }

        public float CraneRating { get; set; }

        public float DragonRating { get; set; }

        public float LionRating { get; set; }

        public float PhoenixRating { get; set; }

        public float ScorpionRating { get; set; }

        public float UnicornRating { get; set; }

        public int CrabTotalVotes { get; set; }

        public int CraneTotalVotes { get; set; }

        public int DragonTotalVotes { get; set; }

        public int LionTotalVotes { get; set; }

        public int PhoenixTotalVotes { get; set; }

        public int ScorpionTotalVotes { get; set; }

        public int UnicornTotalVotes { get; set; }
    }
}