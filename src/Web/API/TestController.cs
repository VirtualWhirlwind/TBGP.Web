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
        [HttpGet]
        public ActionResult<string> GetNow()
        {
            return DateTime.Now.ToString("yyyy-MM-DD HH:mm:ss");
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetEcho(string id)
        {
            return string.Format("Echo ({0:yyyy-MM-DD HH:mm:ss}): {1}", DateTime.Now, id);
        }
    }
}