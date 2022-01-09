using Microsoft.EntityFrameworkCore;
using Proj2;
using Proj2.Shared;
namespace Proj2.Server.Data;

public class AppDbContext : DbContext {


	public DbSet<Company> Companies { get; set; }
	public DbSet<Project> Projects { get; set; }
	public DbSet<Ticket> Tickets { get; set; }
	public DbSet<User> Users { get; set; }

	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
	{

	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

		Company[] companiesToSeed = new Company[3];
		Project[] projectsToSeed = new Project[3];
		Ticket[] ticketsToSeed = new Ticket[3];
		User[] usersToSeed = new User[3];

		for (int i = 0; i < companiesToSeed.Length; i++)
		{
			
			companiesToSeed[i] = new Company
			{
				CompanyId = i + 1,
				Name = "Company " + (i + 1),
				Address = "Room 32" + (i + 1) + ", London Bridge, SE1",
			};

			projectsToSeed[i] = new Project
			{
				ProjectId = i + 1,
				Name = "Project " + (i + 1),
				Description = "Project " + (i + 1) + " description...",
				CompanyID = companiesToSeed[i].CompanyId,
				DueDate = new DateTime(2022, 2, (3 + i)),
			};

			ticketsToSeed[i] = new Ticket
			{
				TicketId = i + 1,
				Name = "Ticket " + (i + 1),
				Description = "Ticket " + (i + 1) + " description...",
				ProjectID = projectsToSeed[i].ProjectId,
				UserID = (i + 1),
			};
	
			usersToSeed[i] = new User
			{
				UserId = i + 1,
				Name = "Name " + (i + 1),
				Address = (i + 1) + " Apple Street, London, NW1",
				CompanyID = companiesToSeed[i].CompanyId,
			};
		}

		modelBuilder.Entity<Company>().ToTable("Companies");
		modelBuilder.Entity<Project>().ToTable("Projects");
		modelBuilder.Entity<Ticket>().ToTable("Tickets");
		modelBuilder.Entity<User>().ToTable("Users");

		modelBuilder.Entity<Company>().HasData(companiesToSeed);
		modelBuilder.Entity<Project>().HasData(projectsToSeed);
		modelBuilder.Entity<Ticket>().HasData(ticketsToSeed);
		modelBuilder.Entity<User>().HasData(usersToSeed);

	}


}