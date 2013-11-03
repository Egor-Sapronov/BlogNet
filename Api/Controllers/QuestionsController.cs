using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data.Contracts;

namespace Api.Controllers
{
    public class QuestionsController : ApiControllerBase
    {
        public QuestionsController(ISqlUow uow)
        {
            Uow = uow;
        }

        // GET api/questions
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/questions/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/questions
        public void Post([FromBody]string value)
        {
        }

        // PUT api/questions/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/questions/5
        public void Delete(int id)
        {
        }
    }
}
