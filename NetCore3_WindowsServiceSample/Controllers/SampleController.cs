using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NetCore3_WindowsServiceSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SampleController : ControllerBase
    {


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new{msg="hello"});
        }
    }
}