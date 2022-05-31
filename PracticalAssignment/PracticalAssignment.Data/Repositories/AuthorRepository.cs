using PracticalAssignment.Data.Entities;
using PracticalAssignment.Data.Repositories.Interfaces;

namespace PracticalAssignment.Data.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(PracticalAssignmentDbContext context)
            :base(context)
        {
        }
    }
}
