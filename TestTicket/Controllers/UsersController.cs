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
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            _context.LogInformation.Add(new LogInformation
            {
                UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                Informations = "Usuário acessou a lista de usuários existentes."
            });
            await _context.SaveChangesAsync();
            return View(await _context.Users.ToListAsync());
        }

        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.userId == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( [FromForm] Users users)
        {
            if (ModelState.IsValid)
            {
                _context.Add(users);

                _context.LogInformation.Add(new LogInformation
                {
                    UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                    Informations = "Usuário criou novo usuário" 
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }
            return View(users);
        }


        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [FromForm] Users users)
        {
            if (id != users.userId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(users);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsersExists(users.userId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                _context.LogInformation.Add(new LogInformation
                {
                    UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                    Informations = "Usuário editou informações do usuário" + id.ToString()
                });
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(users);
        }

        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _context.Users
                .FirstOrDefaultAsync(m => m.userId == id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _context.Users.FindAsync(id);
            _context.Users.Remove(users);
            
            _context.LogInformation.Add(new LogInformation
            {
                UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                Informations = "Usuário deletou informações do usuário" + id.ToString()
            });
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsersExists(int id)
        {
            return _context.Users.Any(e => e.userId == id);
        }
    }
}
