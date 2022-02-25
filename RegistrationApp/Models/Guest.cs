using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RegistrationApp.Models
{
    public class Guest
    {
        [Key]
        public int GuestId { get; set; }

        [DisplayName("First Name")]
        [Required]
        public string firstName { get; set; }

        [DisplayName("Last Name")]
        [Required]
        public string surName { get; set; }

        [DisplayName("Email")]
        [Required]
        public string email { get; set; }

        [DisplayName("Contact")]
        [Required]
        public int phoneNumber { get; set; }

        [DisplayName("Checked In")]
        [Required]

        public DateTime checkIn { get; set; }

        [DisplayName("Checked Out")]
        public DateTime checkOut { get; set; }

        [DisplayName("Room Type")]
        [Required]

        public string roomType { get; set; }

        [DisplayName("Room Number")]
        [Required]

        public int roomNum { get; set; }

        [DisplayName("Advanced payment")]
        [Required]

        public double advancePay { get; set; }

        [DisplayName("Due Amount")]
        [Required]

        public double duePay { get; set; }

        [DisplayName("Total Amount")]
        [Required]
        public double totalAmount { get; set; }

        [DisplayName("Entry By")]
        [Required]
        public int entryBy { get; set; }
    }
}
