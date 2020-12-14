using System.Threading.Tasks;
using CRCompras.Models;

namespace CRCompras.Persistence
{
    public interface IVehicleRepository
    {
        Task<Vehicle> GetVehicle(int id, bool includeRelated = true);
        void AddVehicle(Vehicle vehicle);
        void RemoveVehicle(Vehicle vehicle);
    }


}