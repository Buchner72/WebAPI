using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class Values2Controller : ApiController
    {
        public IEnumerable<String> Get()
        {
            return new string[] { "value1", "value2" };
        }
    }
}
