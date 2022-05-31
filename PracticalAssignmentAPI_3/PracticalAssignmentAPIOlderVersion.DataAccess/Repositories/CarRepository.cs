using PracticalAssignmentAPIOlderVersion.DataAccess.Entities;
using PracticalAssignmentAPIOlderVersion.DataAccess.Repositories.Interfaces;

namespace PracticalAssignmentAPIOlderVersion.DataAccess.Repositories
{
    public class CarRepository : BaseRepository<Car>, ICarRepository
    {
        public CarRepository(PracticalAssignmentAPIDbContext context)
            : base(context)
        {

        }
    }
}
