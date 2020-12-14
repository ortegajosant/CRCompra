using System.Threading.Tasks;
using AutoMapper;
using CRCompras.Controllers;
using CRCompras.Persistence;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace CRCompra_1.Test
{
    public class UnitTest1
    {
       [Test]
       public void Test1()
       {
           Assert.AreEqual(1, 1);
       }

       [Test]
       public async Task Test2()
       {
           var mapper = new Mock<IMapper>();
           var repository = new Mock<IVehicleRepository>();
           var unitOfWork = new Mock<IUnitOfWork>();
           IVehicleRepository _repo = new MockVehicleRepository();

           var _test = new VehiclesController(mapper.Object, _repo, unitOfWork.Object);
           var vehicle = await _test.GetVehicle(1);
           Assert.IsInstanceOf<ObjectResult>(vehicle);

           var objectResponse = vehicle as ObjectResult;
           Assert.AreEqual(200, objectResponse.StatusCode); 
       }
       [Test]
       public async Task Test3()
       {
           var mapper = new Mock<IMapper>();
           var repository = new Mock<IVehicleRepository>();
           var unitOfWork = new Mock<IUnitOfWork>();
           IVehicleRepository _repo = new MockVehicleRepository();

           var _test = new VehiclesController(mapper.Object, _repo, unitOfWork.Object);
           var vehicle = await _test.GetVehicle(99);
           vehicle.Should().BeOfType<NotFoundResult>();
       }
       [Test]
       public async Task Test4()
       {
           var mapper = new Mock<IMapper>();
           var repository = new Mock<IVehicleRepository>();
           var unitOfWork = new Mock<IUnitOfWork>();
           IVehicleRepository _repo = new MockVehicleRepository();

           var _test = new VehiclesController(mapper.Object, _repo, unitOfWork.Object);
           var vehicle = await _test.GetVehicle(-1);
           vehicle.Should().BeOfType<NotFoundResult>();
       }
       [Test]
       public async Task DeleteTest()
       {
           var mapper = new Mock<IMapper>();
           var repository = new Mock<IVehicleRepository>();
           var unitOfWork = new Mock<IUnitOfWork>();
           IVehicleRepository _repo = new MockVehicleRepository();

           var _test = new VehiclesController(mapper.Object, _repo, unitOfWork.Object);
           var vehicle = await _test.DeleteVehicle(0);
           Assert.IsInstanceOf<ObjectResult>(vehicle);

           var objectResponse = vehicle as ObjectResult;
           Assert.AreEqual(200, objectResponse.StatusCode); 
       }
    }
}