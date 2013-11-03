using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Contracts
{
    public interface IQuestionRepository : IRepository<Question>
    {
        IQueryable<Question> GetByUserId(int userId);

        IQueryable<Question> GetByTagId(int tagId);
    }
}
