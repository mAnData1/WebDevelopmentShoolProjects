using AutoMapper;
using PracticalAssignment.Business.Model.Authors;
using PracticalAssignment.Business.Services.Interfaces;
using PracticalAssignment.Data.Entities;
using PracticalAssignment.Data.Repositories.Interfaces;

namespace PracticalAssignment.Business.Services
{
    public class AuthorService : BaseService<Author, AuthorModel, IAuthorRepository>, IAuthorService
    {
        public AuthorService(IAuthorRepository repository, IMapper mapper)
            : base(repository, mapper)
        {
        }
    }
}
