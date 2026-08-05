using System.ComponentModel.DataAnnotations;

namespace HospitalManagement.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(100)]
        public string DepartmentName { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Description { get; set; }
    }
}