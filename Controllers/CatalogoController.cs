using Microsoft.AspNetCore.Mvc;
using GrupoPrueba2.Models;
using GrupoPrueba2.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


namespace GrupoPrueba2.Controllers
{
    public class CatalogoController:Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        public CatalogoController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Tarjeta()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Memoria()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Fuente()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Disco()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> SSD()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Case()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Placa()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

        public async Task<IActionResult> Pc()
        {
            var productos = from o in _context.DataProducts select o;
            return View(await productos.ToListAsync());
        }

         public async Task<IActionResult> Details(int id)
        {
            Catalogo objProduct = await _context.DataProducts.FindAsync(id);
            if(objProduct == null){
                return NotFound();
            }
            return View(objProduct);
        }

        public async Task<IActionResult> Add (int? id){
            var userID = _userManager.GetUserName(User);
            if(userID == null){
                ViewData["Message"] = "Por favor debe loguearse antes de agregar un producto";
                List<Catalogo> productos = new List<Catalogo>();
                return View("Index",productos);
            }else{
                var producto = await _context.DataProducts.FindAsync(id);
                Proforma proforma = new Proforma();
                proforma.Producto = producto;
                proforma.Price = producto.Price;
                proforma.Quantity = 1;
                proforma.UserID = userID;
                _context.Add(proforma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
        }
    }
    
} 