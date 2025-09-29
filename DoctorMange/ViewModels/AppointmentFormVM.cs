using System.ComponentModel.DataAnnotations;

namespace DoctorMange.ViewModels
{
    public class AppointmentFormVM
    {
        // بيانات الدكتور
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }

        // بيانات المريض
        [Required]
        public string PatientName { get; set; }

        [Required, Phone]
        public string Phone { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public int? Age { get; set; }

        [Required]
        public DateTime BookingDate { get; set; }

        [Required]
        public string BookingTime { get; set; }

        public string Notes { get; set; }

    }

}
