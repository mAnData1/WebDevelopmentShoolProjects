using AutoMapper;
using PracticalAssignmentAPIOlderVersion.Business.Models.Brand;
using PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using PracticalAssignmentAPIOlderVersion.DataAccess.Repositories.Interfaces;

namespace PracticalAssignmentAPIOlderVersion.Business.Services
{
    public class BrandService : BaseService<Brand, BrandRequestModel, BrandResponseModel, IBrandRepository>, IBrandService
    {
        public BrandService(IBrandRepository brandRepository, IMapper mapper)
            : base(brandRepository, mapper)
        {

        }
    }
}
