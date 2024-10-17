namespace PRM_API.Dtos;

public class BookingSeatDTO
{
    public int BookingSeatId { get; set; }

    public int? BookingId { get; set; }

    public int SeatId { get; set; }

    public string BookingSeatStatus { get; set; }

    public virtual BookingDTO? Booking { get; set; }

    public virtual SeatDTO? Seat { get; set; }
}