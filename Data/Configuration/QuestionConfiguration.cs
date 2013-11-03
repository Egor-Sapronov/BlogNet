using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using Model;

namespace Data.Configuration
{
    public class QuestionConfiguration:EntityTypeConfiguration<Question>
    {
        public QuestionConfiguration()
        {
            HasMany(s => s.UsersInQuestions)
                .WithRequired(p => p.Question)
                .HasForeignKey(s => s.QuestionId);

            HasMany(s => s.UsersInAnswers)
                .WithRequired(p => p.Question)
                .HasForeignKey(s => s.QuestionId);

            HasMany(s => s.QuestionRating)
                .WithRequired(p => p.Question)
                .HasForeignKey(s => s.QuestionId);

            HasMany(s => s.QuestionsInTags)
                .WithRequired(p => p.Question)
                .HasForeignKey(s => s.QuestionId);
        }
    }
}
