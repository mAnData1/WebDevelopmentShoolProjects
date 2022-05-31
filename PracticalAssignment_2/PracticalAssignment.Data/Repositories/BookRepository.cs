using PracticalAssignment.Data.Entities;
using PracticalAssignment.Data.Repositories.Interfaces;

namespace PracticalAssignment.Data.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {
        public BookRepository(PracticalAssignmentDbContext context)
            : base(context)
        {
        }
    }
}
