using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Data.Contracts;
using Model;

namespace Data
{
    public class PostRepository:EFRepository<Post>,IPostRepository
    {
        public PostRepository(DbContext context) : base(context) { }

        public IQueryable<Post> GetPostsByUserId(int id)
        {
            var query = from post in DbSet.Include(p => p.UserProfile)
                           where post.UserProfileId == id
                           select post;

            return query;
        }
    }
}
