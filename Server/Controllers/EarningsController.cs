using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web.Shared;

namespace web.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EarningsController : ControllerBase
    {
        private static readonly IList<EarningModel> Earnings = new List<EarningModel>();
        private readonly ILogger<EarningsController> _logger;

        public EarningsController(ILogger<EarningsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<EarningModel> Get()
        {
            return Earnings;
        }

        [HttpPost]
        public void Create(EarningModel earning)
        {
            Earnings.Add(earning);
        }
    }
}
