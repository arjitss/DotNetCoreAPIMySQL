using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SamplWebApp.Context;
using SamplWebApp.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SamplWebApp.Controllers
{
    [Route("api/[controller]")]
    public class DaysController : Controller
    {
        private DaysContext _context;

        public DaysController(DaysContext days)
        {
            _context = days;
        }

        // GET: api/Days
        [HttpGet]
        public IEnumerable<Days> Get()
        {
            return _context.Days;
        }

        // GET api/Days/5
        [HttpGet("{id}")]
        public async Task<ActionResult>GetDays([FromRoute]int id)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }
            var days = await _context.Days.FindAsync(id);

            if (days == null)
            {
                return NotFound();
            }

            return Ok(days);
        }
    }
}
