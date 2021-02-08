using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {


        private UserContext _db;
        public WeatherForecastController(UserContext db)
        {
            _db = db;
        }
       
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            DbSeeder dbSeeder = new DbSeeder(_db);
            await dbSeeder.Seed();
            return Ok();
        }

    }
}
