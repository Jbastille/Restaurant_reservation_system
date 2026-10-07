using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservationSystem.Models;

[Table("Reservations")] // This data need to match the exact Column names in the database. 
public class Reservation
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
}