using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Reservation.Api.Models;

public class Reservations
{
    [Key]
    [Column("ReservationId")] 
    public int Id { get; set; }

    [Column("CustomerName")] 
    public string? ClientName { get; set; }

    [Column("ReservationDate")] 
    public DateTime Date { get; set; }

    [Column("PartySize")]
    public int PartySize { get; set; }

    [Column("Status")]
    public string? Status { get; set; }

    // --- Foreign Key for Table ---
    [Column("table_id")]
    public int? TableId { get; set; }
    
    [ForeignKey("table_id")]
    public Table? Table { get; set; } // Navigation property

    // --- Foreign Key for User ---
    [Column("user_id")]
    public int? UserId { get; set; }

    [ForeignKey("user_id")]
    public User? User { get; set; } // Navigation property
}
