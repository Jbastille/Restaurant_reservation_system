using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservation.Api.Models;

public class Customer
{
    [Key]
    [Column("customer_id")]
    public int Id { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [Column("last_name")]
    public string LastName { get; set; } = string.Empty;

    [Column("email")]
    public string Email { get; set; } = string.Empty;

    [Column("phone")]
    public string Phone { get; set; } = string.Empty;

    [Column("is_vip")]
    public bool IsVip { get; set; }

    [Column("notes")]
    public string? SpecialNotes { get; set; }

    // Navigation property: One customer can have many reservations over time
    public ICollection<Reservations> Reservations { get; set; } = new List<Reservations>();
}