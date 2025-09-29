using MedicalCenter.Models;
using System.ComponentModel.DataAnnotations;

namespace DoctorMange.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Range(0, 120)]
        public int? Age { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public TimeSpan BookingTime { get; set; }

        [MaxLength(200)]
        public string? Notes { get; set; }

        public Doctor Doctor { get; set; }
    }


}
