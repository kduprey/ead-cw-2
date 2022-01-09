using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj2.Shared
{
    public class Project
	{
		[Key]
		public int ProjectId { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;

		[Required]
		[MaxLength(300)]
		public string Description { get; set; } = string.Empty;

		[Required]
		public DateTime DueDate { get; set; }

		public int CompanyID { get; set; }
		[ForeignKey("CompanyID")]
		public Company? Company { get; set; }

		[DisplayFormat(NullDisplayText = "Not completed")]
		public DateTime CompletedDate { get; set; }

		[DisplayFormat(NullDisplayText = "No Tickets")]
		public List<Ticket>? Tickets { get; set; }
	}
}