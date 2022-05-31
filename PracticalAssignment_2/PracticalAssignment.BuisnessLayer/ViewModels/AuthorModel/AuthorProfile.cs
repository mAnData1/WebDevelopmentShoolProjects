using AutoMapper;
using PracticalAssignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalAssignment.BuisnessLayer.ViewModels.AuthorModel
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorModelView>().ReverseMap();
        }
    }
}
