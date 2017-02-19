namespace HR_Management.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        QuestId = c.Int(nullable: false),
                        Questions_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Questions", t => t.Questions_id)
                .Index(t => t.Questions_id);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        QuizId = c.Int(nullable: false),
                        QuestionTypeId = c.Int(nullable: false),
                        Quizzes_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.QuestionTypes", t => t.QuestionTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Quizzes", t => t.Quizzes_id)
                .Index(t => t.QuestionTypeId)
                .Index(t => t.Quizzes_id);
            
            CreateTable(
                "dbo.QuestionTypes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Quizzes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CorrectAnswers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(nullable: false),
                        AnswersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ResultQuizs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Result = c.String(),
                        Date = c.DateTime(nullable: false),
                        QuizId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Answers", "Questions_id", "dbo.Questions");
            DropForeignKey("dbo.Questions", "Quizzes_id", "dbo.Quizzes");
            DropForeignKey("dbo.Questions", "QuestionTypeId", "dbo.QuestionTypes");
            DropIndex("dbo.Questions", new[] { "Quizzes_id" });
            DropIndex("dbo.Questions", new[] { "QuestionTypeId" });
            DropIndex("dbo.Answers", new[] { "Questions_id" });
            DropTable("dbo.ResultQuizs");
            DropTable("dbo.CorrectAnswers");
            DropTable("dbo.Quizzes");
            DropTable("dbo.QuestionTypes");
            DropTable("dbo.Questions");
            DropTable("dbo.Answers");
        }
    }
}
