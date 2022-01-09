using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proj2.Shared
{
	public class Ticket
	{
		[Key]
		public int TicketId { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; } = string.Empty;

		[Required]
		[MaxLength(300)]
		public string Description { get; set; } = string.Empty;

		public int ProjectID { get; set; }
		[ForeignKey("ProjectID")]
		public Project? Project { get; set; }

		public int UserID { get; set; }
		[ForeignKey("UserID")]
		public User? User { get; set; }

	}

}
