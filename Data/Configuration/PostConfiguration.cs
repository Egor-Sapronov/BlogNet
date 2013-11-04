using System.Data.Entity.ModelConfiguration;
using Model;


namespace Data
{
    public class PostConfiguration:EntityTypeConfiguration<Post>
    {
        public PostConfiguration()
        {
            HasMany(s => s.Comments)
                .WithRequired(p => p.Post)
                .HasForeignKey(p => p.PostId);
        }
    }
}
