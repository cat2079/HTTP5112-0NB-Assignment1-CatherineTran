using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NB_Assignment1_CatherineTran.Controllers
{
    public class GreetingController : ApiController
    {
        /// <summary>
        /// [Q.3] Returns the string "Hello World!"
        /// when executed in the command prompt
        /// as it is a POST rather than a GET request
        /// </summary>
        /// <returns>
        /// ["Hello World!"] in the command prompt
        /// </returns>
        /// <example>
        /// In the command prompt type:
        /// curl -d "" "http://localhost:{port-number}/api/Greeting" -> ["Hello World!"]
        /// </example>
        public IEnumerable<string> POST()
        {
            return new string[] {"Hello World!"};
        }  
    }
}
