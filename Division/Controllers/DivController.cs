using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Division.Controllers
{
    [Route("Division-Service")]
    public class DivController : Controller
    {
        [Route("Div")]
        public IActionResult Get([FromQuery] int No1, [FromQuery] int No2)
        {
            return Content((No1 / No2).ToString());
        }
    }
}
