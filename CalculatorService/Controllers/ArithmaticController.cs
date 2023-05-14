using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CalculatorService.Controllers
{
    [Route("Calculate")]
    public class ArithmaticController : Controller
    {
        [HttpGet]
        [Route("Add")]
        public IActionResult Addition([FromQuery] int No1, [FromQuery] int No2)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://localhost:44342/Addition-Service/Add?No1={0}&No2={1}", No1, No2);
            HttpResponseMessage respone = client.GetAsync(url).Result;
            if (respone.IsSuccessStatusCode)
            {
                return new JsonResult("The Result of Addition is: " + respone.Content.ReadAsStringAsync().Result);
            }
            throw new Exception("Internal Server  Error");
        }

        [HttpGet]
        [Route("Sub")]
        public IActionResult Subtraction([FromQuery] int No1, [FromQuery] int No2)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://localhost:44366/Subtraction-Service/Sub?No1={0}&No2={1}", No1, No2);
            HttpResponseMessage respone = client.GetAsync(url).Result;
            if (respone.IsSuccessStatusCode)
            {
                return new JsonResult("The Result of Subtraction is: " + respone.Content.ReadAsStringAsync().Result);
            }
            throw new Exception("Internal Server  Error");
        }

        [HttpGet]
        [Route("Mul")]
        public IActionResult Multiplication([FromQuery] int No1, [FromQuery] int No2)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://localhost:44326/Multiplication-Service/Mul?No1={0}&No2={1}", No1, No2);
            HttpResponseMessage respone = client.GetAsync(url).Result;
            if (respone.IsSuccessStatusCode)
            {
                return new JsonResult("The Result of Multiplication is: " + respone.Content.ReadAsStringAsync().Result);
            }
            throw new Exception("Internal Server  Error");
        }

        [HttpGet]
        [Route("Div")]
        public IActionResult Division([FromQuery] int No1, [FromQuery] int No2)
        {
            HttpClient client = new HttpClient();
            string url = string.Format("https://localhost:44367/Division-Service/Div?No1={0}&No2={1}", No1, No2);
            HttpResponseMessage respone = client.GetAsync(url).Result;
            if (respone.IsSuccessStatusCode)
            {
                return new JsonResult("The Result of Division is: " + respone.Content.ReadAsStringAsync().Result);
            }
            throw new Exception("Internal Server  Error");
        }
    }
}
