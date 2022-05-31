using AutoMapper;
using PracticalAssignment.Business.Model.Authors;
using PracticalAssignment.Business.Model.Books;
using PracticalAssignment.Data.Entities;
using System.Linq;

namespace PracticalAssignment.Business.Configuration
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Author, AuthorModel>()
                .ForMember(am => am.BookIds,
                o => o.MapFrom(a => a.Books.Select(b => b.Id)));

            CreateMap<AuthorModel, Author>()
                .ForMember(a => a.Books,
                o => o.MapFrom(am => am.BookIds.Select(b => new Book { Id = b })));

            CreateMap<Book, BookModel>().ReverseMap();
        }
    }
}
