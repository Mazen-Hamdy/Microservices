using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Subtraction.Controllers
{
    [Route("Subtraction-Service")]
    public class SubController : Controller
    {
        [Route("Sub")]
        public IActionResult Get([FromQuery] int No1, [FromQuery] int No2)
        {
            return Content((No1 - No2).ToString());
        }
    }
}
