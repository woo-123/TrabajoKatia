using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GrupoPrueba2.Data;
using GrupoPrueba2.Models;

namespace frutosecoapp.Controllers.Rest
{
    [ApiController]
    [Route("api/productos")]
    public class ProductoRestController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProductoRestController(ApplicationDbContext context){
             _context = context;
        }

        [HttpGet]
        public IEnumerable<Catalogo> ListProductos()
        {
             var listProductos=_context.DataProducts.OrderBy(s => s.Id).ToList();   
             return listProductos.ToArray();
        }

        [HttpGet("{id}")]
        public Catalogo GetProduct(int? id)
        {
            var producto =  _context.DataProducts.Find(id);
            return producto;
        }

        [HttpPost]
        public Catalogo CreateProduct(Catalogo producto){
            _context.Add(producto);
            _context.SaveChanges();
            return producto;
        }

    }
}