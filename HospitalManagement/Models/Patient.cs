using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required]
        [Display(Name = "اسم المريض")]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "العمر")]
        public int Age { get; set; }

        [Display(Name = "النوع")]
        public string Gender { get; set; } = string.Empty;

        [Display(Name = "رقم الهاتف")]
        public string? Phone { get; set; }

        [Display(Name = "العنوان")]
        public string? Address { get; set; }

        [Display(Name = "فصيلة الدم")]
        public string? BloodGroup { get; set; }
    }
}