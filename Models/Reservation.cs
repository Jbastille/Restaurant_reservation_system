namespace ReservationSystem.Models;
public class Reservation
{
    public int Id{get; set;}
    public string? ClientName{get; set;}
    public DateTime Date{get; set;}
    public int PartySize{get; set;}
    public string? Status{get; set;}
    
}