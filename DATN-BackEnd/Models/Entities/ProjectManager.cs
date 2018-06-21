using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DATN_BackEnd.Models.Entities
{
    public class ProjectManager:DbContext
    {
        public ProjectManager() : base("DATNConnectionString")
        {

        }


        public DbSet<Account> Accounts { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<NewsType> NewsTypes { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<AnswerInfo> AnswerInfos { get; set; }

        public DbSet<AnswerType> AnswerTypes { get; set; }

        public DbSet<TestType> TestTypes { get; set; }
    }
}