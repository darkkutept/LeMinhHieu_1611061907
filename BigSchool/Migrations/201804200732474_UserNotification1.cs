namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserNotification1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserNotifications", "UserId", "dbo.AspNetUsers");
            AddForeignKey("dbo.UserNotifications", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserNotifications", "UserId", "dbo.AspNetUsers");
            AddForeignKey("dbo.UserNotifications", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
    }
}
