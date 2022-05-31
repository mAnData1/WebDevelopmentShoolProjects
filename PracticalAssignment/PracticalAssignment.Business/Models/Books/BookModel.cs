using System;
using System.Collections.Generic;
using System.Text;

namespace PracticalAssignment.Business.Model.Books
{
    public class BookModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
    }
}
