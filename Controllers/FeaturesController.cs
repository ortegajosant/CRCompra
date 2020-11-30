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
    public class FeaturesController : Controller
    {
        private readonly CRCompraDBContext context;
        private readonly IMapper mapper;
        public FeaturesController(CRCompraDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}