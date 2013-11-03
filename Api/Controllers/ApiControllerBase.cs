using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data.Contracts;

namespace Api.Controllers
{
    public abstract class ApiControllerBase : ApiController
    {
        protected ISqlUow Uow { get; set; }
    }
}
