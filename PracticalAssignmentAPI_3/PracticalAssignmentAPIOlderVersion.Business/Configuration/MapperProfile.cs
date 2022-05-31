using AutoMapper;
using PracticalAssignmentAPIOlderVersion.Business.Models.Brand;
using PracticalAssignmentAPIOlderVersion.Business.Models.Car;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;

namespace PracticalAssignmentAPIOlderVersion.Business.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // Brand
            CreateMap<BrandRequestModel, Brand>();
            CreateMap<Brand, BrandResponseModel>();

            // Car
            CreateMap<CarRequestModel, Car>();
            CreateMap<Car, CarResponseModel>();
        }
    }
}
