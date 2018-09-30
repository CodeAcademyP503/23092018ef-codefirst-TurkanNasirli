namespace Bank_codefFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "bankApp.Credits",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Disburs = c.DateTime(nullable: false, storeType: "smalldatetime"),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Person_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("bankApp.People", t => t.Person_ID, cascadeDelete: true)
                .Index(t => t.Person_ID);
            
            CreateTable(
                "bankApp.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        CardNumber = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("bankApp.Credits", "Person_ID", "bankApp.People");
            DropIndex("bankApp.Credits", new[] { "Person_ID" });
            DropTable("bankApp.People");
            DropTable("bankApp.Credits");
        }
    }
}
