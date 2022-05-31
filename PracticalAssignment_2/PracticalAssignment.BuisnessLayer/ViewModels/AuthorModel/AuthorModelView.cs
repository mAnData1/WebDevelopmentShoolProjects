using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticalAssignment.BuisnessLayer.ViewModels.AuthorModel
{
    public class AuthorModelView
    {
        [Required]
        [StringLength(100,MinimumLength = 2)]
        public string Name { get; set; }

    }
}
