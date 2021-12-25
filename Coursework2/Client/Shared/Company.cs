using System;
namespace Coursework2.Client.Shared
{
	public class Company
	{

		private string companyName { get; set; }
		private List<User>? employeeList { get; set; }
		private List<Project>? companyProjects { get; set; }

        public Company(string companyName, List<User> employeeList, List<Project> companyProjects)
        {
            this.companyName = companyName;
            this.employeeList = employeeList;
            this.companyProjects = companyProjects;
        }

        public Company()
		{
			companyName = "Company Name";
			employeeList = null;
			companyProjects = null;
		}
	}
}

