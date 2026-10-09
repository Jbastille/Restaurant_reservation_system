using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservation.Api.Models;

public class Table
{
    [Key]
    [Column("table_id")]
    public int Id { get; set; }

    [Column("table_number")]
    public int TableNumber { get; set; }

    [Column("capacity")]
    public int Capacity { get; set; }

    [Column("is_available")]
    public bool IsAvailable { get; set; }
}
