using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Model;
using Data.Contracts;

namespace Data
{
    class AnswerRepository:EFRepository<Answer>,IAnswerRepository
    {
        public AnswerRepository(DbContext context) : base(context) { }

        public IQueryable<Answer> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Answer> GetByQuestionId(int questionId)
        {
            throw new NotImplementedException();
        }
    }
}
