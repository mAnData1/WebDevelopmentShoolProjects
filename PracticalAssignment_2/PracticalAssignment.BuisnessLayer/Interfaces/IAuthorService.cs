using PracticalAssignment.BuisnessLayer.ViewModels.AuthorModel;
using PracticalAssignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalAssignment.BuisnessLayer.Interfaces
{
    public interface IAuthorService : IBaseService <Author, AuthorModelView>
    {
    }
}
