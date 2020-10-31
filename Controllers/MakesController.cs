using System.Collections.Generic;
using System.Threading.Tasks;
using CRCompras.Models;
using CRCompras.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRCompras.Controllers
{
    public class MakesController : Controller
    {
        private readonly CRCompraDBContext context;
        public MakesController(CRCompraDBContext context)
        {
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<Make>> GetMakes()
        {
            return await context.Makes.Include(m => m.Models).ToListAsync();
        }
    }
}