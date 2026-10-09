namespace Reservation.Api.Data;
using Microsoft.EntityFrameworkCore;
using Reservation.Api.Models;


public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)

        : base(options){}
    
    
    public DbSet<User> Users { get; set; }
    public DbSet<Table> Tables { get; set; }
    public DbSet<Reservations> Reservations { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<DiningSlot> DiningSlots { get; set; }
}
