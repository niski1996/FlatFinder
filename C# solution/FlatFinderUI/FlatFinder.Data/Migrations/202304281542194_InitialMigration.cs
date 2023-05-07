namespace FlatFinder.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        LoginEmail = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        ZipCode = c.String(),
                        CreditCard = c.String(),
                        ExpDate = c.String(),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.Announcement",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FlatId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SessionInDomainId = c.Int(nullable: false),
                        PhoneNumber = c.String(),
                        AnnounceDate = c.DateTime(nullable: false),
                        Announcer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Announcer", t => t.Announcer_Id)
                .Index(t => t.Announcer_Id);
            
            CreateTable(
                "dbo.Announcer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Broker = c.Boolean(nullable: false),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        EntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Domain",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EntityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Flat",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ForSale = c.Boolean(nullable: false),
                        City = c.String(),
                        District = c.String(),
                        Street = c.String(),
                        Number = c.Int(),
                        Area = c.Single(nullable: false),
                        Rooms = c.Int(),
                        Floor = c.Int(nullable: false),
                        SeedPointId = c.Int(nullable: false),
                        Distance = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SeedPoint",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Country = c.String(),
                        City = c.String(),
                        District = c.String(),
                        Street = c.String(),
                        Number = c.Int(),
                        Longitude = c.String(),
                        Latitiude = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SessionInDomain",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SessionId = c.Int(nullable: false),
                        DomainId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                        Positive = c.Int(nullable: false),
                        Negative = c.Int(nullable: false),
                        Unknown = c.Int(nullable: false),
                        Repated = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Session",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SessionDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Announcement", "Announcer_Id", "dbo.Announcer");
            DropIndex("dbo.Announcement", new[] { "Announcer_Id" });
            DropTable("dbo.Session");
            DropTable("dbo.SessionInDomain");
            DropTable("dbo.SeedPoint");
            DropTable("dbo.Flat");
            DropTable("dbo.Domain");
            DropTable("dbo.Announcer");
            DropTable("dbo.Announcement");
            DropTable("dbo.Account");
        }
    }
}
