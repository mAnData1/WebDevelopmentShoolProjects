using AutoMapper;
using PracticalAssignment.BuisnessLayer.Interfaces;
using PracticalAssignment.BuisnessLayer.ViewModels.AuthorModel;
using PracticalAssignment.Data.Entities;
using PracticalAssignment.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalAssignment.BuisnessLayer
{
    class AutherService : BaseService<Author, AuthorModelView, IAuthorRepository> , IAuthorService
    {
        public AutherService(IAuthorRepository repository, IMapper mapper) :
            base(repository,mapper)
        {

        }
    }
}
