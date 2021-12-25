using System;
namespace Coursework2.Client.Shared
{
	public class Project
	{
		private string projName { get; set; }
		private string projDescription { get; set; }
		private List<Ticket>? projTasks { get; set; }

        public Project(string projName, string projDescription, List<Ticket> projTasks)
        {
            this.projName = projName;
            this.projDescription = projDescription;
            this.projTasks = projTasks;
        }

        public Project()
		{
			projName = "Project Name";
			projDescription = "Project Description";
			projTasks = null;
		}
	}
}

