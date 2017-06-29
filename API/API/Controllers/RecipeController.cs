using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class RecipeController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return null;
        }
        
        public string Get(int id)
        {
            return null;
        }

        //add a Recipe
        public void Post([FromBody] string[] value)
        {

        }
    }
}
