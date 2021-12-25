using System;
namespace Coursework2.Client.Shared
{
	public class User
	{

		private string fName { get; set; }
		private string lName { get; set; }
		private string address { get; set; }

        public User(string fName, string lName, string address)
        {
            this.fName = fName;
            this.lName = lName;
            this.address = address;
        }

        public User()
        {
            fName = "First Name";
            lName = "Last Name";
            address = "Address";
        }
    }
}

