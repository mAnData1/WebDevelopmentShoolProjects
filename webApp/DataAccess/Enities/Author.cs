using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Enities
{
    public class Author : BaseEnity
    {
        [Required]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
