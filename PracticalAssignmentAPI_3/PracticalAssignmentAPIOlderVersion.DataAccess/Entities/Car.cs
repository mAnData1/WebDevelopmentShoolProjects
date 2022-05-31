using System;

namespace PracticalAssignmentAPIOlderVersion.DataAccess.Entities
{
    public class Car : BaseEntity
    {
        public int YearOfProduction { get; set; }
        public string Model { get; set; }
        public Guid BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
