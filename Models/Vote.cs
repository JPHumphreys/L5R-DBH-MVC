using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace L5R_DBH_MVC.Models
{
    public class Vote
    {
        public string Username { get; set; }//get from ApplicationUser

        public string Id { get; set; }//get from cards

        [StringLength(8)]//scorpion longest string
        [MinLength(4)]//crab,lion
        public string Clan { get; set; }

        [Range(1.0,10.0)]
        public float Rating { get; set; }
    }
}