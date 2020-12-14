using System.Threading.Tasks;
using CRCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace CRCompras.Persistence
{
    public class VehicleRepository : IVehicleRepository
    {
        private readonly CRCompraDBContext context;
        public VehicleRepository(CRCompraDBContext context)
        {
            this.context = context;
        }

        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            if (includeRelated)
                return await context.Vehicle
                    .Include(v => v.Features)
                        .ThenInclude(vf => vf.Feature)
                    .Include(v => v.Model)
                        .ThenInclude(vm => vm.Make)
                    .SingleOrDefaultAsync(v => v.Id == id);
            return await context.Vehicle.FindAsync(id);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            context.Vehicle.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            context.Vehicle.Remove(vehicle);
        }
    }


}