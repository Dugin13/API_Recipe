using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace API.Controllers
{
    public class UserController : ApiController
    {
        // do not think that get are going to be used for user
        // GET api/User
        public IEnumerable<string> Get()
        {
            return new string[] { "boom", "lol" };
        }

        // GET api/User/5
        public string Get(int id)
        {
            int temp = id + 5;
            return id.ToString() + " + " + 5.ToString() + " = " + temp.ToString();
        }

        // going to be used for login and create user
        // skal bruge JSON application/json i postman
        // POST api/User
        public void Post([FromBody] string[] value)
        {
            int temp = 1 + 1;
            if (value != null)
            {
            }
        }

        // for updating user password if it is gonne be made
        // PUT api/User/5
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
