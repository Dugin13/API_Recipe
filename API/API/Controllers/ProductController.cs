using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProductController : ApiController
    {
        // get list of all product in the DB
        public IEnumerable<string> Get()
        {
            return null;
        }


        // get a single product by DB id
        public string Get(int id)
        {
            return null;
        }

        // adding a new product (might not be needed)
        public void Post([FromBody] string[] value)
        {

        }


    }
}
