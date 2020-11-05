using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CRCompras.Controllers.Resources;
using CRCompras.Models;
using CRCompras.Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRCompras.Controllers
{
    public class MakesController : Controller
    {
        private readonly CRCompraDBContext context;
        private readonly IMapper mapper;
        public MakesController(CRCompraDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}