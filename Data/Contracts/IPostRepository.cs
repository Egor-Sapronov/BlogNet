using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Contracts
{
    public interface IPostRepository:IRepository<Post>
    {
        /// <summary>
        /// Subset of posts for one UserProfile
        /// </summary>
        /// <param name="id">Id of UserProfile</param>
        /// <returns></returns>
        IQueryable<Post> GetPostsByUserId(int id);          
    }
}
