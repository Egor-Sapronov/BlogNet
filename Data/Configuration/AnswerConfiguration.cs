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
    public class AnswerConfiguration:EntityTypeConfiguration<Answer>
    {
        public AnswerConfiguration()
        {
            HasMany(s => s.UsersInAnswers)
                .WithRequired(p => p.Answer)
                .HasForeignKey(s => s.AnswerId);

            HasMany(s => s.AnswerRating)
                .WithRequired(p => p.Answer)
                .HasForeignKey(s => s.AnswerId);
        }
    }
}
