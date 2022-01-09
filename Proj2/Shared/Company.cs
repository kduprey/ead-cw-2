using System.ComponentModel.DataAnnotations;

namespace Proj2.Shared
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(300)]
        public string Address { get; set; } = string.Empty;

        [DisplayFormat(NullDisplayText = "No projects")]
        public List<Project>? Projects { get; set; }

        [DisplayFormat(NullDisplayText = "No Users")]
        public List<User>? Users { get; set; }

    }

}