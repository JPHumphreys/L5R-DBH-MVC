﻿namespace L5R_DBH_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCoreCrabDynastyCards : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',0,3,NULL,0,0,0,'eager-scout','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_25.jpg',0,0,'false','false',0,NULL,'Eager Scout',0,NULL,NULL,'dynasty',0,NULL,NULL,'character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',1,3,NULL,0,1,0,'hida-guardian','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_26.jpg',0,0,'false','false',1,NULL,'Hida Guardian',1,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is participating in a conflict, choose another participating character – until the end of the conflict, that character gets +2[conflict-military] and +2[conflict-political] for each holding you control.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',1,3,NULL,0,1,0,'kaiu-envoy','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_27.jpg',0,0,'false','false',1,NULL,'Kaiu Envoy',0,NULL,NULL,'dynasty',0,NULL,'Courtesy. <i>(When this character leaves play, gain 1 fate.)</i> Sincerity. <i>(When this character leaves play, draw 1 card.)</i>','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',2,3,NULL,0,2,0,'hiruma-yojimbo','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_28.jpg',0,0,'false','false',4,NULL,'Hiruma Yōjimbō',3,NULL,NULL,'dynasty',0,NULL,'This character cannot be declared as an attacker.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',2,3,NULL,0,1,0,'shrewd-yasuki','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_29.jpg',0,0,'false','false',1,NULL,'Shrewd Yasuki',2,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is participating in a conflict, if there is a holding in play – look at the top 2 cards of your conflict deck. Add 1 of those cards to your hand and place the other on the bottom of your conflict deck.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',2,3,NULL,0,1,0,'vanguard-warrior','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_30.jpg',0,0,'false','false',2,NULL,'Vanguard Warrior',1,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> Sacrifice this character. Choose a character – place 1 fate on that character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',3,3,NULL,0,1,0,'borderlands-defender','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_31.jpg',0,0,'false','false',3,NULL,'Borderlands Defender',3,NULL,NULL,'dynasty',0,NULL,'While this character is defending, opponents'' card effects cannot bow it or move it.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',3,3,NULL,0,1,0,'intimidating-hida','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_32.jpg',0,0,'false','false',4,NULL,'Intimidating Hida',2,NULL,NULL,'dynasty',0,NULL,'<b>Reaction:</b> After an opponent passes on declaring a conflict – that player loses 1 honor.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',3,3,NULL,0,0,0,'vengeful-berserker','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_33.jpg',0,0,'false','false',3,NULL,'Vengeful Berserker',0,NULL,NULL,'dynasty',0,NULL,'<b>Reaction:</b> After another character you control leaves play during a conflict – double this character''s [conflict-military] skill until the end of the conflict.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',3,3,NULL,0,2,0,'hida-tomonatsu','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_34.jpg',0,0,'false','false',3,NULL,'Hida Tomonatsu',2,NULL,NULL,'dynasty',0,NULL,'<b>Reaction:</b> After this character wins a conflict as a defender, sacrifice it. Choose a non-unique attacking character – return that character to the top of its owner''s deck.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',4,3,NULL,0,0,0,'steadfast-witch-hunter','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_35.jpg',0,0,'false','false',4,NULL,'Steadfast Witch Hunter',2,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> Sacrifice a <i>(friendly)</i> character. Choose a character – ready that character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',4,3,NULL,0,2,0,'kaiu-shuichi','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_36.jpg',0,0,'false','false',3,NULL,'Kaiu Shuichi',3,NULL,NULL,'dynasty',0,NULL,'Covert. <i>(When this character attacks, choose one character without covert. That character cannot be declared as a defender.)</i> <b>Action:</b> During a conflict in which this character is participating, if there is a holding in play – gain 1 fate.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',5,3,NULL,0,0,0,'hida-kisada','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_37.jpg',0,0,'false','false',7,NULL,'Hida Kisada',2,NULL,NULL,'dynasty',0,NULL,'While you have not lost a conflict this phase, cancel the effects of the first action ability your opponent triggers from a card during each conflict.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',0,3,NULL,0,0,0,'borderlands-fortifications','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_38.jpg',0,0,'false','false',0,NULL,'Borderlands Fortifications',0,NULL,NULL,'dynasty',0,+2,'<b>Action:</b> Choose a card in one of your provinces – switch this holding with that card.','holding','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crab',0,3,NULL,0,0,0,'funeral-pyre','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_39.jpg',0,0,'false','false',0,NULL,'Funeral Pyre',0,NULL,NULL,'dynasty',0,+0,'<b>Action:</b> Sacrifice a <i>(friendly)</i> character – draw 1 card.','holding','false');");
        }
        
        public override void Down()
        {
        }
    }
}
