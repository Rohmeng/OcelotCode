using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiA.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
    public class CounterController : Controller
    {
        private static int _count = 0;

        [HttpGet]
        public string Count()
        {
            return $"Count {++_count} from WebapiA";
        }
    }
}