using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L5R_DBH_MVC.Models
{
    public class Deck
    {
        public string Username { get; set; }

        public string Id { get; set; }

        public string DeckName { get; set; }

        public byte Quantity { get; set; }
    }
}