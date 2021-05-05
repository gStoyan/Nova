using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nova.Web.Areas.Users.Controllers
{
    public class BaseApiController : ControllerBase
    {
        protected IActionResult HandleException(
            Exception ex, string msg)
        {
            IActionResult ret;
           
            ret = StatusCode(StatusCodes.Status500InternalServerError,
                new Exception(msg));
            return ret;
        }
    }
}
