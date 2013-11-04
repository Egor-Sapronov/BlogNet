using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Contracts;
using Model;
using Data.Contracts;

namespace Api.Controllers
{
    public class CommentController : ApiControllerBase, ICrud<Comment>
    {
        public CommentController(ISqlUow uow)
        {
            Uow = uow;
        }

        //
        // GET: /api/comment

        public IEnumerable<Comment> Get()
        {
            return Uow.Comments.GetAll();
        }

        public Comment Get(int id)
        {
            return Uow.Comments.GetById(id);
        }

        public void Post(Comment value)
        {
            Uow.Comments.Add(value);
        }

        public void Put(Comment value)
        {
            Uow.Comments.Update(value);
        }

        public void Delete(int id)
        {
            Uow.Comments.Delete(id);
        }
    }
}
