using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorMeal.Data.Entities
{
    [Table("Restaurant")]
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
        public string WebSiteAddress { get; set; }
    }
}
