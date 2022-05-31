using AutoMapper;
using PracticalAssignmentAPIOlderVersion.Business.Models.Car;
using PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using PracticalAssignmentAPIOlderVersion.DataAccess.Repositories.Interfaces;

namespace PracticalAssignmentAPIOlderVersion.Business.Services
{
    public class CarService : BaseService<Car, CarRequestModel, CarResponseModel, ICarRepository>, ICarService
    {
        public CarService(ICarRepository carRepository, IMapper mapper)
            : base(carRepository, mapper)
        {

        }
    }
}
