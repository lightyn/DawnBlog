namespace DawnBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogPost",
                c => new
                    {
                        BlogPost_Id = c.Int(nullable: false, identity: true),
                        Body = c.String(nullable: false),
                        Title = c.String(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        User_User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.BlogPost_Id)
                .ForeignKey("dbo.User", t => t.User_User_Id)
                .Index(t => t.User_User_Id);
            
            CreateTable(
                "dbo.BlogPostComment",
                c => new
                    {
                        BlogPostComment_Id = c.Int(nullable: false, identity: true),
                        CommentBody = c.String(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                        BlogPost_BlogPost_Id = c.Int(),
                        User_User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.BlogPostComment_Id)
                .ForeignKey("dbo.BlogPost", t => t.BlogPost_BlogPost_Id)
                .ForeignKey("dbo.User", t => t.User_User_Id)
                .Index(t => t.BlogPost_BlogPost_Id)
                .Index(t => t.User_User_Id);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        User_Id = c.Int(nullable: false, identity: true),
                        IsContentAuthor = c.Boolean(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                        UserName = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.User_Id);
            
            CreateTable(
                "dbo.PasswordHash",
                c => new
                    {
                        PasswordHash_Id = c.Int(nullable: false),
                        Salt = c.String(),
                    })
                .PrimaryKey(t => t.PasswordHash_Id)
                .ForeignKey("dbo.User", t => t.PasswordHash_Id)
                .Index(t => t.PasswordHash_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogPost", "User_User_Id", "dbo.User");
            DropForeignKey("dbo.PasswordHash", "PasswordHash_Id", "dbo.User");
            DropForeignKey("dbo.BlogPostComment", "User_User_Id", "dbo.User");
            DropForeignKey("dbo.BlogPostComment", "BlogPost_BlogPost_Id", "dbo.BlogPost");
            DropIndex("dbo.PasswordHash", new[] { "PasswordHash_Id" });
            DropIndex("dbo.BlogPostComment", new[] { "User_User_Id" });
            DropIndex("dbo.BlogPostComment", new[] { "BlogPost_BlogPost_Id" });
            DropIndex("dbo.BlogPost", new[] { "User_User_Id" });
            DropTable("dbo.PasswordHash");
            DropTable("dbo.User");
            DropTable("dbo.BlogPostComment");
            DropTable("dbo.BlogPost");
        }
    }
}
