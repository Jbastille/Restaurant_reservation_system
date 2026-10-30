using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservation.Api.Models;

public class Reservations
{
    [Key]
    [Column("reservation_id")] 
    public int Id { get; set; }

    [Column("reservation_date")] 
    public DateTime Date { get; set; }

    [Column("party_size")]
    public int PartySize { get; set; }

    [Column("status")]
    public string? Status { get; set; }

    // --- Customer Relationship ---
    [Column("customer_id")]
    public int? CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    public Customer? Customer { get; set; }

    // --- Table Relationship ---
    [Column("table_id")]
    public int? TableId { get; set; }
    
    [ForeignKey("TableId")]
    public Table? Table { get; set; }

    // --- User Relationship ---
    [Column("user_id")]
    public int? UserId { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }
}