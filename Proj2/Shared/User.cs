using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj2.Shared
{
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required]
		[MaxLength(50)]
		public string Name { get; set; } = string.Empty;

        [Required]
		[MaxLength(300)]
		public string Address { get; set; } = string.Empty;

		public int CompanyID { get; set; }
		[ForeignKey("CompanyID")]
		[Required]
		public Company? Company { get; set; }

		[DisplayFormat(NullDisplayText = "No projects")]
		public List<Project>? Projects { get; set; }
		[DisplayFormat(NullDisplayText = "No tickets")]
		public List<Ticket>? Tickets { get; set; }
	}
}