using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L5R_DBH_MVC.Models
{
    public class Vote
    {
        public string Username { get; set; }//get from ApplicationUser

        public string Id { get; set; }//get from cards

        public string Clan { get; set; }

        public float Rating { get; set; }
    }
}