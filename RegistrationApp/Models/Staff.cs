using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationApp.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string firstName { get; set; }
        [DisplayName("Last Name")]
        [Required]
        public string surName { get; set; }
        [DisplayName("Position")]
        [Required]
        public string position { get; set; }
    }
}
