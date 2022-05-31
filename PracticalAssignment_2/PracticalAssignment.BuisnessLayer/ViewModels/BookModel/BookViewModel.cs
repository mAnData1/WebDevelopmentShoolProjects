using PracticalAssignment.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PracticalAssignment.BuisnessLayer.ViewModels
{
    public class BookViewModel
    {
        [Required]
        [StringLength(100,MinimumLength = 3)]
        public string Title { get; set; }
        [Required]
        public Guid AuthorId { get; set; }
        [Required]
        public Author Author { get; set; }
    }
}
