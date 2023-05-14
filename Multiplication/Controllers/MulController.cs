using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiplication.Controllers
{
    [Route("Multiplication-Service")]
    public class MulController : Controller
    {
        [Route("Mul")]
        public IActionResult Get([FromQuery] int No1, [FromQuery] int No2)
        {
            return Content((No1 * No2).ToString());
        }
    }
}
