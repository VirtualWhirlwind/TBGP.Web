using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("Now")]
        public ActionResult<string> Now()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        [HttpGet("Echo/{input}")]
        public ActionResult<string> Echo(string input)
        {
            return string.Format("Echo ({0:yyyy-MM-dd HH:mm:ss}): {1}", DateTime.Now, input);
        }
    }
}