using System.Collections.Generic;
using System.Threading.Tasks;
using CRCompras.Models;

namespace CRCompras.Persistence
{
    public class MockVehicleRepository : IVehicleRepository
    {
        List<Vehicle> vehicleList = new List<Vehicle>();

        public MockVehicleRepository()
        {
            SetUp();
        }

        private void SetUp()
        {
            Vehicle mockSimpleVehicle;
            for (int i = 0; i <= 3; i++)
            {
                mockSimpleVehicle = new Vehicle();
                mockSimpleVehicle.Id = i;
                mockSimpleVehicle.ContactName = "MockContact" + i;
                mockSimpleVehicle.IsRegistered = true;
                vehicleList.Add(mockSimpleVehicle);
            }
        }
        public void AddVehicle(Vehicle vehicle)
        {
            vehicleList.Add(vehicle);
        }

        public async Task<Vehicle> GetVehicle(int id, bool includeRelated = true)
        {
            await Task.Delay(100);
            var response = vehicleList.Find(v => v.Id == id);
            if (response == null)
                return null;
            return response;
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicleList.Remove(vehicle);
        }
    }
}