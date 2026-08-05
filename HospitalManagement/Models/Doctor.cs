using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HospitalManagement.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }

        [Required]
        [Display(Name = "اسم الطبيب")]
        public string DoctorName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "التخصص")]
        public string Specialization { get; set; } = string.Empty;

        [Display(Name = "رقم الهاتف")]
        public string? Phone { get; set; }

        [Display(Name = "البريد الإلكتروني")]
        public string? Email { get; set; }

        [Display(Name = "القسم")]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
    }
}