using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NB_Assignment1_CatherineTran.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// [Q.1] Returns 10 more than the integer input {id}
        /// Input must be a positive or negative integer
        /// </summary>
        /// <param name="id">The input integer</param>
        /// <returns>
        /// Ten more than the integer input
        /// </returns>
        /// <example>
        /// GET http:localhost/api/AddTen/{id}
        /// GET localhost/api/AddTen/21 -> 31
        /// GET localhost/api/AddTen/0 -> 10
        /// GET localhost/api/AddTen/-9 -> 1
        /// </example>
        public int Get(int id)
        {
            int a = id + 10;
            return a;
        }
    }
}
