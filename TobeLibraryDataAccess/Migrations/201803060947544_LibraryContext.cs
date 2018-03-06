namespace TobeLibraryDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        FirstName = c.String(),
                        Email = c.String(),
                        PhoneNo = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        Surname = c.String(),
                        OtherName = c.String(),
                        Designation = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BorrowedBooks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                        DateBorrowed = c.DateTime(nullable: false),
                        DateToReturn = c.DateTime(nullable: false),
                        IsReturned = c.Boolean(nullable: false),
                        DateReturned = c.DateTime(),
                        AdminId = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                        Administrator_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Administrators", t => t.Administrator_Id)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.BookId)
                .Index(t => t.Administrator_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DrawerId = c.Int(nullable: false),
                        Name = c.String(),
                        Author = c.String(),
                        ISBN = c.String(),
                        DatePublished = c.DateTime(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drawers", t => t.DrawerId, cascadeDelete: true)
                .Index(t => t.DrawerId);
            
            CreateTable(
                "dbo.Drawers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Surname = c.String(),
                        FirstName = c.String(),
                        OtherName = c.String(),
                        Email = c.String(),
                        PhoneNo = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        Faculty = c.String(),
                        Department = c.String(),
                        Level = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        DateModified = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BorrowedBooks", "UserId", "dbo.Users");
            DropForeignKey("dbo.Books", "DrawerId", "dbo.Drawers");
            DropForeignKey("dbo.BorrowedBooks", "BookId", "dbo.Books");
            DropForeignKey("dbo.BorrowedBooks", "Administrator_Id", "dbo.Administrators");
            DropIndex("dbo.Books", new[] { "DrawerId" });
            DropIndex("dbo.BorrowedBooks", new[] { "Administrator_Id" });
            DropIndex("dbo.BorrowedBooks", new[] { "BookId" });
            DropIndex("dbo.BorrowedBooks", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Drawers");
            DropTable("dbo.Books");
            DropTable("dbo.BorrowedBooks");
            DropTable("dbo.Administrators");
        }
    }
}
