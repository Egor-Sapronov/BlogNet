using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Data.Contracts
{
    public interface IAnswerRepository : IRepository<Answer>
    {
        IQueryable<Answer> GetByUserId(int userId);

        IQueryable<Answer> GetByQuestionId(int questionId);
    }
}
