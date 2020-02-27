﻿namespace L5R_DBH_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatingCorePhoenixDynasty : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',1,3,NULL,0,2,0,'naive-student','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_81.jpg',0,0,'false','false',0,NULL,'Naive Student',2,NULL,NULL,'dynasty',0,NULL,'Sincerity. <i>(When this character leaves play, draw 1 card.)</i>','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',1,3,NULL,0,1,0,'shiba-peacemaker','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_82.jpg',0,0,'false','false',4,NULL,'Shiba Peacemaker',1,NULL,NULL,'dynasty',0,NULL,'This character cannot participate in conflicts as an attacker.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',1,3,NULL,0,1,0,'solemn-scholar','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_83.jpg',0,0,'false','false',1,NULL,'Solemn Scholar',1,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> During a conflict, if the [element-earth] ring is in your claimed ring pool, choose an attacking character – bow that character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',2,3,NULL,0,2,0,'adept-of-the-waves','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_84.jpg',0,0,'false','false',2,NULL,'Adept of the Waves',2,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> Choose a character – until the end of the phase, that character gains covert during [element-water] conflicts.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',2,3,NULL,0,1,0,'asako-diplomat','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_85.jpg',0,0,'false','false',1,NULL,'Asako Diplomat',2,NULL,NULL,'dynasty',0,NULL,'<b>Reaction:</b> After this character wins a conflict, choose a character – honor or dishonor that character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',2,3,NULL,0,1,0,'meddling-mediator','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_86.jpg',0,0,'false','false',0,NULL,'Meddling Mediator',3,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> If an opponent has declared 2 or more conflicts against you this phase, select one – take 1 fate or 1 honor from that opponent.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',3,3,NULL,0,2,0,'radiant-orator','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_87.jpg',0,0,'false','false',1,NULL,'Radiant Orator',2,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> While this character is participating in a conflict, if you count more current glory than your opponent among ready participating characters, choose an enemy character – move that character home.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',3,3,NULL,0,4,0,'serene-warrior','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_88.jpg',0,0,'false','false',3,NULL,'Serene Warrior',2,NULL,NULL,'dynasty',0,NULL,NULL,'character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',3,3,NULL,0,2,0,'shiba-yojimbo','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_89.jpg',0,0,'false','false',3,NULL,'Shiba Yōjimbō',2,NULL,NULL,'dynasty',0,NULL,'<b>Interrupt:</b> When the effects of a triggered ability that targets a <em>Shugenja</em> you control would initiate – cancel those effects.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',3,3,NULL,0,2,0,'isawa-masahiro','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_90.jpg',0,0,'false','false',3,NULL,'Isawa Masahiro',2,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> During a [element-fire] conflict, bow this character. Choose a participating character with printed cost 2 or lower – discard that character.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',4,3,NULL,0,1,0,'fearsome-mystic','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_91.jpg',0,0,'false','false',2,NULL,'Fearsome Mystic',4,NULL,NULL,'dynasty',0,NULL,'This character gets +2 glory during [element-air] conflicts. <b>Action:</b> While this character is participating in a conflict – remove 1 fate from each participating character your opponent controls with lower glory than this character.','character','false');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',4,3,NULL,0,2,0,'isawa-atsuko','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_92.jpg',0,0,'false','false',3,NULL,'Isawa Atsuko',3,NULL,NULL,'dynasty',0,NULL,'<b>Action:</b> During a [element-void] conflict – until the end of the conflict, each participating character you control gets +1[conflict-military] and +1[conflict-political] and each participating character your opponent controls gets –1[conflict-military] and –1[conflict-political].','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',5,3,NULL,0,4,0,'shiba-tsukune','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_93.jpg',0,0,'false','false',4,NULL,'Shiba Tsukune',4,NULL,NULL,'dynasty',0,NULL,'<b>Interrupt:</b> When the conflict phase ends – resolve the ring effects of up to 2 unclaimed rings as if you were the attacking player.','character','true');");
            Sql("INSERT INTO Cards(Clan, Cost, DeckLimit, Element, Fate, Glory, Honor, Id, ImageLocation, InfluenceCost, InfluencePool, IsBanned, IsRestricted, Military, MilitaryBonus, Name, Political, PoliticalBonus, RoleRestriction, Side, Strength, StrengthOf, Text, CardType, Unicity) VALUES ('phoenix',0,3,NULL,0,0,0,'forgotten-library','http://lcg-cdn.fantasyflightgames.com/l5r/L5C01_94.jpg',0,0,'false','false',0,NULL,'Forgotten Library',0,NULL,NULL,'dynasty',0,+0,'<b>Reaction:</b> After the draw phase begins – draw 1 card.','holding','false');");
        }
        
        public override void Down()
        {
        }
    }
}
