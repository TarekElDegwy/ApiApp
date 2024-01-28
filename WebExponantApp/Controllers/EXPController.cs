using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebExponantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EXPController : ControllerBase
    {
        // GET: api/<EXPController>
        [HttpGet("/Exponant")]
        public int Power([FromQuery] int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result = result * x;
            }
            
            return result;
        }
    }
}
