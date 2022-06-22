namespace ThingsILearned.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String());
        }
    }
}
