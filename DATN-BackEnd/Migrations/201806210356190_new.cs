namespace DATN_BackEnd.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Question", "AnswerType_id", "dbo.AnswerType");
            DropIndex("dbo.Question", new[] { "AnswerType_id" });
            DropColumn("dbo.Question", "answer_type");
            RenameColumn(table: "dbo.Question", name: "AnswerType_id", newName: "answer_type");
            AlterColumn("dbo.Question", "answer_type", c => c.Int(nullable: false));
            CreateIndex("dbo.Question", "answer_type");
            AddForeignKey("dbo.Question", "answer_type", "dbo.AnswerType", "id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Question", "answer_type", "dbo.AnswerType");
            DropIndex("dbo.Question", new[] { "answer_type" });
            AlterColumn("dbo.Question", "answer_type", c => c.Int());
            RenameColumn(table: "dbo.Question", name: "answer_type", newName: "AnswerType_id");
            AddColumn("dbo.Question", "answer_type", c => c.Int(nullable: false));
            CreateIndex("dbo.Question", "AnswerType_id");
            AddForeignKey("dbo.Question", "AnswerType_id", "dbo.AnswerType", "id");
        }
    }
}
