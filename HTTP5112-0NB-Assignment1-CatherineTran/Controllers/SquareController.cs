using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NB_Assignment1_CatherineTran.Controllers
{
    
    public class SquareController : ApiController
    {
        /// <summary>
        /// [Q.2] Returns the square of the integer input {id}
        /// Input must be a postive or negative integer
        /// </summary>
        /// <param name="id">The input integer</param>
        /// <returns>Returns the square of the input integer</returns>
        /// <example>
        /// GET http:localhost/api/Square/{id}
        /// GET localhost/Square/2 -> 4
        /// GET localhost/Square/-2 -> 4
        /// GET localhost/Square/10 -> 100
        /// </example>
        public IEnumerable<int> Get(int id)
        {
            return new int[] { id * id };
        }
    }
}
