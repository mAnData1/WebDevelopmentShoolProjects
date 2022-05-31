using System.Collections.Generic;

namespace PracticalAssignmentAPIOlderVersion.DataAccess.Entities
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
