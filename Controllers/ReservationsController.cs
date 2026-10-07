using Microsoft.AspNetCore.Mvc;
using ReservationSystem.Data;
using ReservationSystem.Models;

namespace ReservationSystem.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ReservationsController : ControllerBase
{
    private readonly AppDbContext _context;

    public ReservationsController(AppDbContext context)
    {
        _context = context;
    }
    // Post: api/reservations
    [HttpPost]
    public async Task<IActionResult> CreateReservation(Reservation reservation)
    {
        _context.Reservations.Add(reservation);
        await _context.SaveChangesAsync();
        return Ok(reservation);
    }

    //this is the testing GET function
    [HttpGet]
    public IActionResult GetAllReservations()
    {
        var reservations = _context.Reservations.ToList();
        return Ok(reservations);
    }


    // GET: api/reservations/{Id}
    [HttpGet("{id}")]
    public IActionResult GetReservation(int id)
    {
        var reservation = _context.Reservations.Find(id);
        if (reservation == null)
            return NotFound();

        return Ok(reservation);
    }

    // DELETE : api/ reservations/ {id}
    [HttpDelete ("{id}")]
    public IActionResult DeleteReservation(int id)
    {
        var reservation = _context.Reservations.Find(id);
        if (reservation == null)
            return NotFound();
        _context.Reservations.Remove(reservation);
        _context.SaveChanges();
        return Ok();
    }

}
