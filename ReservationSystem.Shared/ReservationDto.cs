namespace ReservationSystem.Shared;

public class ReservationDto
{
    public int Id { get; set; }
    public string? Client_Name { get; set; }
    public DateTime Date { get; set; }
    public int PartySize { get; set; }
    public string? Status { get; set; }
}