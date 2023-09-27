using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppyWebApi.Controllers
{
    public class AuthenticationController : ApiController
    {
        [HttpGet]
        [ActionName("CreateToken")]
        public string Token(string username, string password)
        {
            string token = string.Empty;
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {

                // Database call

                token = TokenManager.GenerateToken(username,password, 20);
            }
            return token;
        }
    }
}