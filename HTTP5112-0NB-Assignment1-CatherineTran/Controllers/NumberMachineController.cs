using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5112_0NB_Assignment1_CatherineTran.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// [Q.5] This is a method which has an input {id}
        /// and applies four mathematical operations to it
        /// The input  must be a positive or negative
        /// integer
        /// </summary>
        /// <param name="id">The input integer</param>
        /// <returns>
        /// The result is a value that is rounded down 
        /// to the lowest integer from the result of the
        /// four mathematical calculations applied to it
        /// It returns the input integer squared and then
        /// 5 is subtracted from it - this sum is then divided
        /// by the result of 10 more than the input integer
        /// </returns>
        /// <example>
        /// GET http:localhost/api/NumberMachine/{id}
        /// GET localhost/api/NumberMachine/10 -> 6
        /// GET localhost/api/NumberMachine/-5 -> -1
        /// GET localhost/api/NumberMachine/30 -> 25
        /// </example>
        public IEnumerable<int> Get(int id)
        {
            return new int[] {((id * id) - 5 ) / ( id + 5 )};
        }
    }
}
