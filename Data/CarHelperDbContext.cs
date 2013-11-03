using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using Model;
using Data.Configuration;

namespace Data
{
    public class CarHelperDbContext:DbContext
    {
        public CarHelperDbContext() : base(nameOrConnectionString: "DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new UserProfileConfiguration());
            modelBuilder.Configurations.Add(new QuestionConfiguration());
            modelBuilder.Configurations.Add(new AnswerConfiguration());
            modelBuilder.Configurations.Add(new TagConfiguration());
        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Tag> Tags { get; set; }

        //public DbSet<UsersInQuestions> UsersInQuestions { get; set; }
        //public DbSet<UsersInAnswers> UsersInAnswers { get; set; }
        //public DbSet<QuestionRating> QuestionRatings { get; set; }
        //public DbSet<AnswerRating> AnswerRatings { get; set; }
        //public DbSet<QuestionsInTags> QuestionsInTags { get; set; }
    }  
}
