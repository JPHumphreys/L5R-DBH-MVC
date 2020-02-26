using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace L5R_DBH_MVC.Models
{
    public class Card
    {
        
        public string Id { get; set; }//primary key "shrewd-yasuki"

        public string Name { get; set; }//"shrewd yasuki"

    

        //Game State Values
        public byte Cost { get; set; }

        [Range(1, 3)]
        public byte DeckLimit { get; set; }

        public byte Fate { get; set; }

        public byte Glory { get; set; }

        public byte Honor { get; set; }

        public byte InfluenceCost { get; set; }

        public byte InfluencePool { get; set; }



        // Power Values
        [Range(0,10)]
        public byte Military { get; set; }

        [StringLength(2)]//"+X"
        public string MilitaryBonus { get; set; }

        [Range(0, 10)]
        public byte Political { get; set; }

        [StringLength(2)]
        public string PoliticalBonus { get; set; }

        [Range(0, 10)]
        public byte Strength { get; set; }

        [StringLength(2)]
        public string StrengthOf { get; set; }



        //"True" or "False" Values
        [StringLength(5)]
        [MinLength(4)]
        public string IsBanned { get; set; }

        [StringLength(5)]
        [MinLength(4)]
        public string IsRestricted { get; set; }

        [StringLength(5)]
        [MinLength(4)]
        public string Unicity { get; set; }



        //Card Components
        [StringLength(8)]//scorpion longest string
        [MinLength(4)]//crab,lion
        public string Clan { get; set; }

        [StringLength(5)]//earth
        [MinLength(3)]//air
        public string Element { get; set; }

        [StringLength(6)]//keeper,seeker
        [MinLength(6)]
        public string RoleRestriction { get; set; }

        [StringLength(8)]//province
        [MinLength(4)]//role
        public string Side { get; set; }

        [StringLength(10)]//atta chme nt
        [MinLength(4)]//role
        public string CardType { get; set; }



        //Display Attributes
        public string ImageLocation { get; set; }

        public string Text { get; set; }
    }
}