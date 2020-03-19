using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorMeal.Data.Entities
{
    [Table("Restaurant")]
    public class Restaurant
    {
        public int Id { get; set; }
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [DisplayName("Miasto")]
        public string City { get; set; }
        [DisplayName("Ulica")]
        public string Street { get; set; }
        [DisplayName("Numer telefonu")]
        public string PhoneNumber { get; set; }
        [DisplayName("Strona internetowa")]
        public string WebSiteAddress { get; set; }
    }
}
