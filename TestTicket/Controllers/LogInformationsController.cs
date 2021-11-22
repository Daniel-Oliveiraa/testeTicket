using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestTicket.Data;
using TestTicket.Models;

namespace TestTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInformationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LogInformationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _context.LogInformation.ToListAsync());
        }

        [HttpGet("Details/{id}")]

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var logInformation = await _context.LogInformation
                .FirstOrDefaultAsync(m => m.LogId == id);
            if (logInformation == null)
            {
                return NotFound();
            }

            return View(logInformation);
        }
       
    }
}
