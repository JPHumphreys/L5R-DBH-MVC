using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace L5R_DBH_MVC.ViewModels
{
    public class VoteFormViewModel
    {
        [Required]
        public string Username { get; set; }//get from ApplicationUser

        [Required]
        public string Id { get; set; }//get from cards

        [StringLength(8)]//scorpion longest string
        [MinLength(4)]//crab,lion
        [Required]
        public string Clan { get; set; }

        [Range(1.0, 10.0)]
        [Required]
        public float Rating { get; set; }
    }
}