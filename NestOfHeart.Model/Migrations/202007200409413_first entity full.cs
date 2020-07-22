namespace NestOfHeart.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstentityfull : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        GraduationYear = c.Int(nullable: false),
                        SchoolId = c.Guid(nullable: false),
                        TeacherId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schools", t => t.SchoolId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.SchoolId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Schools",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        ProvinceCode = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Favorites",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Title = c.String(maxLength: 30),
                        Url = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 30),
                        Password = c.String(),
                        Identity = c.Int(nullable: false),
                        DetailId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Title = c.String(maxLength: 30),
                        Content = c.String(),
                        IsRead = c.Boolean(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false),
                        Url = c.String(),
                        Brief = c.String(),
                        Count = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Content = c.String(nullable: false),
                        StudentId = c.Guid(nullable: false),
                        Permission = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(maxLength: 20),
                        ClassId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.ClassId)
                .Index(t => t.ClassId);
            
            CreateTable(
                "dbo.QuestionnaireDetails",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        QuestionnaireId = c.Guid(nullable: false),
                        StudentId = c.Guid(nullable: false),
                        TeacherId = c.Guid(nullable: false),
                        Status = c.Int(nullable: false),
                        Type = c.Int(nullable: false),
                        FinishTime = c.DateTime(nullable: false),
                        Score = c.Single(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questionnaires", t => t.QuestionnaireId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .ForeignKey("dbo.Teachers", t => t.TeacherId)
                .Index(t => t.QuestionnaireId)
                .Index(t => t.StudentId)
                .Index(t => t.TeacherId);
            
            CreateTable(
                "dbo.Questionnaires",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Brief = c.String(maxLength: 50),
                        Type = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        QuestionnaireId = c.Guid(nullable: false),
                        Order = c.Int(nullable: false),
                        Title = c.String(nullable: false),
                        Choice = c.String(nullable: false),
                        Type = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Questionnaires", t => t.QuestionnaireId)
                .Index(t => t.QuestionnaireId);
            
            CreateTable(
                "dbo.StudentMovies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StudentId = c.Guid(nullable: false),
                        MovieId = c.Guid(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Movies", t => t.MovieId)
                .ForeignKey("dbo.Students", t => t.StudentId)
                .Index(t => t.StudentId)
                .Index(t => t.MovieId);
            
            CreateTable(
                "dbo.Weeklies",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(nullable: false, maxLength: 30),
                        Content = c.String(),
                        ReceiverType = c.Int(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        IsRemove = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentMovies", "StudentId", "dbo.Students");
            DropForeignKey("dbo.StudentMovies", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Questions", "QuestionnaireId", "dbo.Questionnaires");
            DropForeignKey("dbo.QuestionnaireDetails", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.QuestionnaireDetails", "StudentId", "dbo.Students");
            DropForeignKey("dbo.QuestionnaireDetails", "QuestionnaireId", "dbo.Questionnaires");
            DropForeignKey("dbo.Notes", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Students", "ClassId", "dbo.Classes");
            DropForeignKey("dbo.Messages", "UserId", "dbo.Users");
            DropForeignKey("dbo.Favorites", "UserId", "dbo.Users");
            DropForeignKey("dbo.Classes", "TeacherId", "dbo.Teachers");
            DropForeignKey("dbo.Classes", "SchoolId", "dbo.Schools");
            DropIndex("dbo.StudentMovies", new[] { "MovieId" });
            DropIndex("dbo.StudentMovies", new[] { "StudentId" });
            DropIndex("dbo.Questions", new[] { "QuestionnaireId" });
            DropIndex("dbo.QuestionnaireDetails", new[] { "TeacherId" });
            DropIndex("dbo.QuestionnaireDetails", new[] { "StudentId" });
            DropIndex("dbo.QuestionnaireDetails", new[] { "QuestionnaireId" });
            DropIndex("dbo.Students", new[] { "ClassId" });
            DropIndex("dbo.Notes", new[] { "StudentId" });
            DropIndex("dbo.Messages", new[] { "UserId" });
            DropIndex("dbo.Favorites", new[] { "UserId" });
            DropIndex("dbo.Classes", new[] { "TeacherId" });
            DropIndex("dbo.Classes", new[] { "SchoolId" });
            DropTable("dbo.Weeklies");
            DropTable("dbo.StudentMovies");
            DropTable("dbo.Questions");
            DropTable("dbo.Questionnaires");
            DropTable("dbo.QuestionnaireDetails");
            DropTable("dbo.Students");
            DropTable("dbo.Notes");
            DropTable("dbo.Movies");
            DropTable("dbo.Messages");
            DropTable("dbo.Users");
            DropTable("dbo.Favorites");
            DropTable("dbo.Teachers");
            DropTable("dbo.Schools");
            DropTable("dbo.Classes");
        }
    }
}
