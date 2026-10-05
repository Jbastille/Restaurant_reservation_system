namespace ReservationSystem.Models;
public class Table
{
    public int TableId { get; set; }
    public int TableNumber { get; set; }
    public int Capacity { get; set; }
    public bool IsAvailable { get; set; }
}
