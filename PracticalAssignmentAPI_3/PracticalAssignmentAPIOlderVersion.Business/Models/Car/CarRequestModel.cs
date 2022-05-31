using System;

namespace PracticalAssignmentAPIOlderVersion.Business.Models.Car
{
    public class CarRequestModel : BaseRequestModel
    {
        public int YearOfProduction { get; set; }
        public string Model { get; set; }
        public Guid BrandId { get; set; }
    }
}
