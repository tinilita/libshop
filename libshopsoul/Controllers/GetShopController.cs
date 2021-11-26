using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace libshopsoul.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetShopController : ControllerBase
    {
        private readonly ILogger<GetShopController> _logger;
        public GetShopControllerr(ILogger<GetShopController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IEnumerable<GetBooks> Get()
        {
            var x = post - put;
            return x;
        }
    }
}
