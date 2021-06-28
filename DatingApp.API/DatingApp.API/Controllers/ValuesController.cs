using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using DatingApp.API.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DatingApp.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public async Task<IActionResult>  GetValues()
        {
            var values =await _context.Values.ToListAsync();
            return Ok(values); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult>  GetValue(int id)
        {
            var value =await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }

    }
}