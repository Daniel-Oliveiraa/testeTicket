using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestTicket.Data;
using TestTicket.Models;

namespace TestTicket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdressesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdressesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("Index/{userId}")]
        public async Task<IActionResult> Index(int? userId)
        {
            

            var id = 0;
            if (userId != 0)
            {
                TempData["UserId"] = userId;
                id = userId.Value;
            }
            else
            {
                TempData["UserId"] = TempData["UserId"];
                
                id = Convert.ToInt32(TempData["UserId"]);
            }
            TempData["UserId"] = TempData["UserId"];
            var applicationDbContext = _context.Adresses.Where(o => o.UserId == id).Include(a => a.user);

            _context.LogInformation.Add(new LogInformation
            {
                UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                Informations = "Usuário acessou Lista de Endereços do usuário " + id.ToString()+" - "+DateTime.Now
            });
            await _context.SaveChangesAsync();
            return View(await applicationDbContext.ToListAsync());
        }

        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adresses = await _context.Adresses
                .Include(a => a.user)
                .FirstOrDefaultAsync(m => m.AdressId == id);
            if (adresses == null)
            {
                return NotFound();
            }

            return View(adresses);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            ViewBag.UserId = TempData["UserId"];
            TempData["UserId"] = TempData["UserId"];
            return View();
        }


        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( [FromForm]Adresses adresses)
        {
            if (ModelState.IsValid)
            {
                _context.LogInformation.Add(new LogInformation
                {
                    UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                    Informations = "Usuário criou novo endereço para o usuário " + adresses.UserId.ToString() + " - " + DateTime.Now
                });
                _context.Add(adresses);
                await _context.SaveChangesAsync();
                ViewBag.UserId = adresses.UserId;
                TempData["UserId"] = adresses.UserId;

                

                return Redirect("https://localhost:44395/api/Adresses/Index/" + adresses.UserId.ToString()); ;
            }
            
            return View(adresses);
        }

        [HttpGet("Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adresses = await _context.Adresses.FindAsync(id);
            if (adresses == null)
            {
                return NotFound();
            }
            ViewBag.UserId = TempData["UserId"];
            TempData["UserId"] = TempData["UserId"];
            return View(adresses);
        }


        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [FromForm] Adresses adresses)
        {
            var userId = adresses.UserId;
            if (id != adresses.AdressId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(adresses);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdressesExists(adresses.AdressId.Value))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                ViewBag.UserId = userId;
                TempData["UserId"] = userId;
                _context.LogInformation.Add(new LogInformation
                {
                    UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                    Informations = "Usuário editou o endereço "+adresses.AdressId.ToString()+" para o usuário " + adresses.UserId.ToString() + " - " + DateTime.Now
                });
                await _context.SaveChangesAsync();
                return Redirect("https://localhost:44395/api/Adresses/Index/"+userId.ToString());
            }

            return View(adresses);
        }

        [HttpGet("Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var adresses = await _context.Adresses
                .Include(a => a.user)
                .FirstOrDefaultAsync(m => m.AdressId == id);
            if (adresses == null)
            {
                return NotFound();
            }

            return View(adresses);
        }

        [HttpPost("Delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var adresses = await _context.Adresses.FindAsync(id);
            _context.Adresses.Remove(adresses);
            await _context.SaveChangesAsync();

            _context.LogInformation.Add(new LogInformation
            {
                UserEmail = "podemosInserirEmailDeUsuarioLogadoParaControle",
                Informations = "Usuário deletou o endereço " + id.ToString() + " para o usuário " + adresses.UserId.ToString() + " - " + DateTime.Now
            });
            await _context.SaveChangesAsync();
            return Redirect("https://localhost:44395/api/Adresses/Index/" + adresses.UserId.ToString()); ;
        }

        private bool AdressesExists(int id)
        {
            return _context.Adresses.Any(e => e.AdressId == id);
        }
    }
}
