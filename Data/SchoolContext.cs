using docker_api.Models;
using Microsoft.EntityFrameworkCore;

namespace docker_api.Data;

public class SchoolContext : DbContext
{
	public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
	{

	}

	public DbSet<Student> Students { get; set; }
}
