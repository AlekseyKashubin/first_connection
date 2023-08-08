#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace first_connection.Models;

public class MyContext : DbContext 
{
    public MyContext(DbContextOptions options) : base(options) { }

    public DbSet<Pet> Pets { get; set; } 
}