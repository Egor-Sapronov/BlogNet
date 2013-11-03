using System;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Model;
using Data.Contracts;

namespace Data
{
    class QuestionRepository:EFRepository<Question>,IQuestionRepository
    {
        public QuestionRepository(DbContext context) : base(context) { }

        public IQueryable<Question> GetByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Question> GetByTagId(int tagId)
        {
            throw new NotImplementedException();
        }
    }
}
