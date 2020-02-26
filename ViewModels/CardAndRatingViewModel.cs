using L5R_DBH_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L5R_DBH_MVC.ViewModels
{
    public class CardAndRatingViewModel
    {
        public Card Card { get; set; }
        public Rating Rating { get; set; }
    }
}