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
    public class PostController : ApiControllerBase, ICrud<Post>
    {
        public PostController(ISqlUow uow)
        {
            Uow = uow;
        }

        public IEnumerable<Post> Get()
        {
            throw new NotImplementedException();
        }

        public Post Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Post value)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, Post value)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
