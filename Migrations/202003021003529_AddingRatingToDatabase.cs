namespace L5R_DBH_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRatingToDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ratings",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OverallRating = c.Single(nullable: false),
                        CrabRating = c.Single(nullable: false),
                        CraneRating = c.Single(nullable: false),
                        DragonRating = c.Single(nullable: false),
                        LionRating = c.Single(nullable: false),
                        PhoenixRating = c.Single(nullable: false),
                        ScorpionRating = c.Single(nullable: false),
                        UnicornRating = c.Single(nullable: false),
                        CrabTotalVotes = c.Int(nullable: false),
                        CraneTotalVotes = c.Int(nullable: false),
                        DragonTotalVotes = c.Int(nullable: false),
                        LionTotalVotes = c.Int(nullable: false),
                        PhoenixTotalVotes = c.Int(nullable: false),
                        ScorpionTotalVotes = c.Int(nullable: false),
                        UnicornTotalVotes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ratings");
        }
    }
}
