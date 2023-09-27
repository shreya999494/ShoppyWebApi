using ShoppyWebApi.DBContext;
using ShoppyWebApi.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace ShoppyWebApi.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly Shoppy_dbEntities1 shoppy_DbEntities;

        public ValuesController()
        {
            this.shoppy_DbEntities = new Shoppy_dbEntities1();
        }

        [HttpPost]
        public int CreateUser(User user)
        {

            this.shoppy_DbEntities.Users.Add(user);
            this.shoppy_DbEntities.SaveChanges();
            return user.U_Id;
        }

        [Authorize]
        [CustomC]
        public IEnumerable<User> GetUsers()
        {
            return this.shoppy_DbEntities.Users.ToList();

        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
