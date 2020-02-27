namespace L5R_DBH_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingLionAndPhoenixConflict : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',2,3,NULL,0,0,0,'vengeful-oathkeeper','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_160.jpg',2,0,'false','false',2,NULL,'Vengeful Oathkeeper',1,NULL,NULL,'conflict',0,NULL,'<b>Reaction:</b> After you lose a [conflict-military] conflict � put this character into play from your hand.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',3,3,NULL,0,1,0,'master-of-the-spear','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_161.jpg',3,0,'false','false',2,NULL,'Master of the Spear',2,NULL,NULL,'conflict',0,NULL,'<b>Action:</b> While this character is attacking, your opponent must choose a participating character he or she controls � move that character home.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',1,3,NULL,0,0,0,'guidance-of-the-ancestors','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_162.jpg',1,0,'false','false',0,'+1','Guidance of the Ancestors',0,+1,NULL,'conflict',0,NULL,'<b>Action:</b> Play this attachment from your conflict discard pile.','attachment','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',1,3,NULL,0,0,0,'honored-blade','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_163.jpg',1,0,'false','false',0,'+2','Honored Blade',0,+0,NULL,'conflict',0,NULL,'Restricted. <i>(No more than two restricted attachments per character.)</i> <b>Reaction:</b> After attached character wins a conflict � gain 1 honor.','attachment','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',2,3,NULL,0,0,0,'sashimono','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_164.jpg',2,0,'false','false',0,'+0','Sashimono',0,+0,NULL,'conflict',0,NULL,'Attach to a <em>Bushi</em> character you control. Attached character does not bow as a result of conflict resolution during [conflict-military] conflicts.','attachment','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',0,3,NULL,0,0,0,'ready-for-battle','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_165.jpg',1,0,'false','false',0,NULL,'Ready for Battle',0,NULL,NULL,'conflict',0,NULL,'<b>Reaction:</b> After an opponent''s card effect or a ring effect bows a character you control � ready that character.','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',0,3,NULL,0,0,0,'stand-your-ground','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_166.jpg',2,0,'false','false',0,NULL,'Stand Your Ground',0,NULL,NULL,'conflict',0,NULL,'<b>Interrupt:</b> When an honored character you control would leave play � instead discard that character''s status token.','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',0,3,NULL,0,0,0,'way-of-the-lion','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_167.jpg',0,0,'false','false',0,NULL,'Way of the Lion',0,NULL,NULL,'conflict',0,NULL,'<b>Action:</b> During a conflict, choose a [clan-lion] character � double that character''s base [conflict-military] skill until the end of the conflict.','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',1,3,NULL,0,0,0,'for-greater-glory','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_168.jpg',3,0,'false','false',0,NULL,'For Greater Glory',0,NULL,NULL,'conflict',0,NULL,'<b>Reaction:</b> After you break a province during a [conflict-military] conflict � place 1 fate on each participating <em>Bushi</em> character you control. (Max 1 per conflict.)','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('lion',1,3,NULL,0,0,0,'strength-in-numbers','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_169.jpg',2,0,'false','false',0,NULL,'Strength in Numbers',0,NULL,NULL,'conflict',0,NULL,'<b>Action:</b> While you are the attacking player, choose a defending character with glory X or lower � move that character home. X is equal to the number of attacking characters.','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',2,3,NULL,0,0,0,'ishiken-initiate','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_170.jpg',2,0,'false','false',1,NULL,'Ishiken Initiate',1,NULL,NULL,'conflict',0,NULL,'This character gets +1[conflict-military] and +1[conflict-political] for each claimed ring.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',2,3,NULL,0,1,0,'seeker-of-knowledge','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_171.jpg',1,0,'false','false',0,NULL,'Seeker of Knowledge',2,NULL,NULL,'conflict',0,NULL,'While this character is attacking, the contested ring gains the [element-air] element. If this character wins the conflict as an attacker, you may choose which of its ring effects to resolve.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',0,3,NULL,0,0,0,'magnificent-kimono','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_172.jpg',1,0,'false','false',0,'+0','Magnificent Kimono',0,+1,NULL,'conflict',0,NULL,'Attached character gains pride. <i>(After this character wins a conflict, honor it. After this character loses a conflict, dishonor it.)</i>','attachment','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',1,3,NULL,0,0,0,'grasp-of-earth','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_173.jpg',1,0,'false','false',0,'+1','Grasp of Earth',0,+1,NULL,'conflict',0,NULL,'Attach to a <em>Shugenja</em> character you control. <b>Action:</b> During a conflict, bow this attachment � opponents'' characters cannot move to this conflict or be played from hand until the end of the conflict.','attachment','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',2,3,NULL,0,0,0,'pacifism','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_174.jpg',2,0,'false','false',0,'+0','Pacifism',0,+0,NULL,'conflict',0,NULL,'This attachment cannot be played during a conflict. Attached character cannot participate in [conflict-military] conflicts.','attachment','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',0,3,NULL,0,0,0,'supernatural-storm','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_175.jpg',1,0,'false','false',0,NULL,'Supernatural Storm',0,NULL,NULL,'conflict',0,NULL,'<b>Action:</b> Choose a participating character � that character gets +X[conflict-military] and +X[conflict-political] until the end of the conflict. X is equal to the number of <em>Shugenja</em> characters you control.','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',0,3,NULL,0,0,0,'way-of-the-phoenix','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_176.jpg',0,0,'false','false',0,NULL,'Way of the Phoenix',0,NULL,NULL,'conflict',0,NULL,'<b>Action:</b> Choose a ring and an opponent � that player cannot declare conflicts of that ring''s element this phase. (Max 1 per phase.)','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',1,3,NULL,0,0,0,'against-the-waves','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_177.jpg',1,0,'false','false',0,NULL,'Against the Waves',0,NULL,NULL,'conflict',0,NULL,'<b>Action:</b> Choose a <em>Shugenja</em> character � bow or ready that character.','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',1,3,NULL,0,0,0,'know-the-world','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_178.jpg',3,0,'false','false',0,NULL,'Know the World',0,NULL,NULL,'conflict',0,NULL,'<b>Action:</b> Switch a ring in your claimed ring pool with an unclaimed ring and gain all fate on that ring. <i>(Retain the ring''s conflict cardType.)</i>','event','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',2,3,NULL,0,0,0,'display-of-power','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_179.jpg',3,0,'false','false',0,NULL,'Display of Power',0,NULL,NULL,'conflict',0,NULL,'<b>Reaction:</b> After you lose an unopposed conflict � cancel the ring effect of that conflict. Then, you resolve that ring effect as if you had won the conflict as the attacking player. Claim that ring.','event','false');");
        }
        
        public override void Down()
        {
        }
    }
}