using AutoMapper;
using PracticalAssignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalAssignment.BuisnessLayer.ViewModels.BookModel
{
    class BookProfile : Profile
    {
        public BookProfile()
        {
            CreateMap<Book, BookViewModel>().ReverseMap();
        }
    }
}
