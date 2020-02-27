namespace L5R_DBH_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCoreCraneDynasty : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',1,3,NULL,0,2,0,'asahina-artisan','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_40.jpg',0,0,'false','false',0,NULL,'Asahina Artisan',0,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> During a conflict, bow this character. Choose another [clan-crane] character � that character gets +3[conflict-political] until the end of the conflict.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',1,3,NULL,0,1,0,'doji-whisperer','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_41.jpg',0,0,'false','false',0,NULL,'Doji Whisperer',3,NULL,NULL,'dynasty',0,NULL,NULL,'character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',2,3,NULL,0,2,0,'brash-samurai','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_42.jpg',0,0,'false','false',2,NULL,'Brash Samurai',1,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is your only participating character in a conflict � honor this character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',2,3,NULL,0,1,0,'cautious-scout','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_43.jpg',0,0,'false','false',2,NULL,'Cautious Scout',0,NULL,NULL,'dynasty',0,NULL,'While this character is attacking alone, treat the defending province as if its printed text box were blank (except for <em>Traits</em>).','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',2,3,NULL,0,1,0,'doji-gift-giver','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_44.jpg',0,0,'false','false',0,NULL,'Doji Gift Giver',2,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is participating in a conflict, give your opponent 1 fate. That opponent must choose a ready participating character he or she controls � bow that character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',2,3,NULL,0,1,0,'savvy-politician','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_45.jpg',0,0,'false','false',1,NULL,'Savvy Politician',2,NULL,NULL,'dynasty',0,NULL,'<b>Reaction:</b> After this character is honored, choose a character � honor that character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',2,3,NULL,0,1,0,'daidoji-nerishma','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_46.jpg',0,0,'false','false',3,NULL,'Daidoji Nerishma',1,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> Choose a facedown card in one of your provinces � turn that card faceup.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',3,3,NULL,0,2,0,'doji-challenger','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_47.jpg',0,0,'false','false',3,NULL,'Doji Challenger',3,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is attacking, choose a character controlled by your opponent � move that character to this conflict.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',3,3,NULL,0,2,0,'kakita-asami','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_48.jpg',0,0,'false','false',1,NULL,'Kakita Asami',3,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is participating in a [conflict-political] conflict, if you count more current [conflict-political] skill in the conflict than your opponent � take 1 honor from that opponent.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',3,3,NULL,0,2,0,'kakita-kaezin','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_49.jpg',0,0,'false','false',3,NULL,'Kakita Kaezin',2,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is participating in a conflict, your opponent must choose a participating character he or she controls � challenge that character to a [conflict-military] duel. If this character wins, move each character not involved in the duel home. If it loses, send it home.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',4,3,NULL,0,2,0,'asahina-storyteller','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_50.jpg',0,0,'false','false',2,NULL,'Asahina Storyteller',4,NULL,NULL,'dynasty',0,NULL,'Sincerity. <i>(When this character leaves play, draw 1 card.)</i> Each honored [clan-crane] character you control gains sincerity.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',4,3,NULL,0,1,0,'guest-of-honor','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_51.jpg',0,0,'true','false',1,NULL,'Guest of Honor',4,NULL,NULL,'dynasty',0,NULL,'While this character is participating in a conflict, opponents cannot play events.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',5,3,NULL,0,3,0,'doji-hotaru','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_52.jpg',0,0,'false','false',3,NULL,'Doji Hotaru',6,NULL,NULL,'dynasty',0,NULL,'<b>Reaction:</b> After you claim a ring during a [conflict-political] conflict in which this character is participating � resolve that ring''s effect.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('crane',0,3,NULL,0,0,0,'artisan-academy','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_53.jpg',0,0,'false','false',0,NULL,'Artisan Academy',0,NULL,NULL,'dynasty',0,+1,'<b>Action:</b> During the conflict phase � reveal the top card of your conflict deck. Until the end of the phase, you may play that card as if it were in your hand.','holding','false');");
        }
        
        public override void Down()
        {
        }
    }
}