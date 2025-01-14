using System.ComponentModel.DataAnnotations;

namespace Webhotel.Models
{
    public class Booking
    {
        public int Id { get; set; } // Auto-increment ID

        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Number of days is required")]
        public string Days { get; set; }

        [Required(ErrorMessage = "Number of adults is required")]
        public string NumOfAdults { get; set; }
    }
}
