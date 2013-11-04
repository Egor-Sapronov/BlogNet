using System.Data.Entity.ModelConfiguration;
using Model;

namespace Data
{
    public class UserProfileConfiguration:EntityTypeConfiguration<UserProfile>
    {
        public UserProfileConfiguration()
        {
            HasMany(s => s.Posts)
                .WithRequired(p => p.UserProfile)
                .HasForeignKey(p => p.UserProfileId);

            HasMany(s => s.Comments)
                .WithRequired(p => p.UserProfile)
                .HasForeignKey(p => p.UserProfileId);
        }
    }
}
