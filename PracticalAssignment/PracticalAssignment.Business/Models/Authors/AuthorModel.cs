using System;
using System.Collections.Generic;

namespace PracticalAssignment.Business.Model.Authors
{
    public class AuthorModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Guid> BookIds { get; set; }

    }
}
