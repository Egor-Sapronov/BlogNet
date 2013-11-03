using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;


namespace Data.Contracts
{
    public interface ITagRepository : IRepository<Tag>
    {
        IQueryable<Tag> GetByQuestionId(int questionId);
    }
}
