using AutoMapper;
using PracticalAssignment.BuisnessLayer.Interfaces;
using PracticalAssignment.BuisnessLayer.ViewModels;
using PracticalAssignment.Data.Entities;
using PracticalAssignment.Data.Repositories;
using PracticalAssignment.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalAssignment.BuisnessLayer
{
    class BookService : BaseService<Book,BookViewModel,IBookRepository>, IBookService
    {
        public BookService(IBookRepository repository, IMapper mapper)
            :base(repository, mapper)
        {

        }
    }
}
