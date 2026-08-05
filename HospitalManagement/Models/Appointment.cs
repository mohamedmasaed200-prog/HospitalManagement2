using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string Reason { get; set; } = string.Empty;

        // Foreign Key
        public int PatientId { get; set; }

        public Patient? Patient { get; set; }

        // Foreign Key
        public int DoctorId { get; set; }

        public Doctor? Doctor { get; set; }
    }
}