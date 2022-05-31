using PracticalAssignmentAPIOlderVersion.Business.Models.Brand;
using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;

namespace PracticalAssignmentAPIOlderVersion.Business.Services.Interfaces
{
    public interface IBrandService : IBaseService<Brand, BrandRequestModel, BrandResponseModel>
    {
    }
}
