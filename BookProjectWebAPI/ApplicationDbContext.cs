using BookProjectWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookProjectWebAPI
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
		}

		public DbSet<Book> Books => Set<Book>();
	}
}
