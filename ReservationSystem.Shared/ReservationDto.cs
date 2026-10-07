namespace ReservationSystem.Shared;

public class ReservationDto
{
    public int Id { get; set; }
    public string CustomerName { get; set; } = string.Empty;
    public string CustomerEmail { get; set; } = string.Empty;
    public DateTime ReservationDate { get; set; }
    public int NumberOfGuests { get; set; }
    public int TableId { get; set; }
}