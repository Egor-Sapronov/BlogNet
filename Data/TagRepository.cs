using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Model;
using Data.Contracts;


namespace Data
{
    public class TagRepository : EFRepository<Tag>, ITagRepository
    {
        public TagRepository(DbContext context) : base(context) { }

        public IQueryable<Tag> GetByQuestionId(int questionId)
        {
            throw new NotImplementedException();
        }
    }
}
