namespace L5R_DBH_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCardsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Cost = c.Byte(nullable: false),
                        DeckLimit = c.Byte(nullable: false),
                        Fate = c.Byte(nullable: false),
                        Glory = c.Byte(nullable: false),
                        Honor = c.Byte(nullable: false),
                        InfluenceCost = c.Byte(nullable: false),
                        InfluencePool = c.Byte(nullable: false),
                        Military = c.Byte(nullable: false),
                        MilitaryBonus = c.String(maxLength: 2),
                        Political = c.Byte(nullable: false),
                        PoliticalBonus = c.String(maxLength: 2),
                        Strength = c.Byte(nullable: false),
                        StrengthOf = c.String(maxLength: 2),
                        IsBanned = c.String(maxLength: 5),
                        IsRestricted = c.String(maxLength: 5),
                        Unicity = c.String(maxLength: 5),
                        Clan = c.String(maxLength: 8),
                        Element = c.String(maxLength: 5),
                        RoleRestriction = c.String(maxLength: 6),
                        Side = c.String(maxLength: 8),
                        CardType = c.String(maxLength: 10),
                        ImageLocation = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cards");
        }
    }
}
