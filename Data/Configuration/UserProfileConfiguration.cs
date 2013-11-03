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
    class UserProfileConfiguration:EntityTypeConfiguration<UserProfile>
    {
        public UserProfileConfiguration()
        {
            HasMany(s => s.UsersInQuestions)
                .WithRequired(p => p.User)
                .HasForeignKey(s => s.UserId);

            HasMany(s => s.UsersInAnswers)
                .WithRequired(p => p.User)
                .HasForeignKey(s => s.UserId);

            HasMany(s => s.QuestionRating)
                .WithRequired(p => p.User)
                .HasForeignKey(s => s.UserId);

            HasMany(s => s.AnswerRating)
                .WithRequired(p => p.User)
                .HasForeignKey(s => s.UserId);

        }
    }
}
