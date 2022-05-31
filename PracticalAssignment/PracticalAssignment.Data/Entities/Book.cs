using System;

namespace PracticalAssignment.Data.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
