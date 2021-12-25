using System;
namespace Coursework2.Client.Shared
{
	public class Ticket
	{
		private string name { get; set; }
		private string description { get; set; }
		private List<User>? assignedUsers { get; set; }

        public Ticket(string name, string description, List<User> assignedUsers)
        {
            this.name = name;
            this.description = description;
            this.assignedUsers = assignedUsers;
        }

        public Ticket()
		{
			name = "Ticket Name";
			description = "Ticket Description";
			assignedUsers = null;
		}
	}
}

