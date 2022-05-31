using PracticalAssignmentAPIOlderVersion.Business.Models.Car;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;

namespace PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces
{
    public interface ICarService : IBaseService<Car, CarRequestModel, CarResponseModel>
    {
    }
}
