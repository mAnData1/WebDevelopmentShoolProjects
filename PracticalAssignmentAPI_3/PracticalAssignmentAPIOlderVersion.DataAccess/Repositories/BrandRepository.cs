using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using PracticalAssignmentAPIOlderVersion.DataAccess.Repositories.Interfaces;

namespace PracticalAssignmentAPIOlderVersion.DataAccess.Repositories
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(PracticalAssignmentAPIDbContext context)
            : base(context)
        {

        }
    }
}
