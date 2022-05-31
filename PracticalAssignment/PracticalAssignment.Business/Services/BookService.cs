using AutoMapper;
using PracticalAssignment.Business.Model.Books;
using PracticalAssignment.Business.Services.Interfaces;
using PracticalAssignment.Data.Entities;
using PracticalAssignment.Data.Repositories.Interfaces;

namespace PracticalAssignment.Business.Services
{
    public class BookService : BaseService<Book, BookModel, IBookRepository>, IBookService
    {
        public BookService(IBookRepository repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }
    }
}
