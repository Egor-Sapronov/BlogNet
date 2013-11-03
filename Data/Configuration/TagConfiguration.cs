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
    public class TagConfiguration:EntityTypeConfiguration<Tag>
    {
        public TagConfiguration()
        {
            HasMany(s => s.QuestionsInTags)
                .WithRequired(p => p.Tag)
                .HasForeignKey(s => s.TagId);
        }
    }
}
