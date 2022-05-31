using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataAccess.Enities
{
    public class Book : BaseEnity
    {
        [Required]
        public string Tile { get; set; }

        public ICollection<Author> Authors{ get; set; }
    }
}
