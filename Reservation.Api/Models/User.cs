using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reservation.Api.Models;

public class User
{
    [Key]
    [Column("user_id")]
    public int Id { get; set; }

    [Column("Username")]
    public string Username { get; set; } = string.Empty;

    [Column("PasswordHash")]
    public string PasswordHash { get; set; } = string.Empty;

    [Column("Role")]
    public string Role { get; set; } = string.Empty;

    [Column("CreatedAt")]
    public DateTime CreatedAt { get; set; }
}