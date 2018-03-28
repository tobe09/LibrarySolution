namespace TobeLibraryDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LibraryContext1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrators", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Administrators", "Password");
        }
    }
}
