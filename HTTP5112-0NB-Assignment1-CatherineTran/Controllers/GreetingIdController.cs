using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NB_Assignment1_CatherineTran.Controllers
{
    public class GreetingIdController : ApiController
    {
        /// <summary>
        /// [Q.4] Returns the string 
        /// "Greetings to {id} people!"
        /// where id is an integer value
        /// Input must be a positive or negative integer
        /// </summary>
        /// <param name="id">Integer input</param>
        /// <returns>
        /// A string that reads "Greetings to {id} people!"
        /// where {id} outputs the number from the integer input
        /// </returns>
        /// <example>
        /// GET http:localhost/api/GreetingId/{id}
        /// GET localhost/GreetingId/3 -> "Greetings to 3 people!"
        /// GET localhost/GreetingId/6 -> "Greetings to 6 people!"
        /// GET localhost/GreetingId/0 -> "Greetings to 0 people!"
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            return new string[] { "Greetings to " + id + " people!"};
        }
    }
}
