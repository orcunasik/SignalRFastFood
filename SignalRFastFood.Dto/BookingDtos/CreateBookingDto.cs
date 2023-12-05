namespace SignalRFastFood.Dto.BookingDtos;

public class CreateBookingDto
{
    public string NameSurname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public byte PersonCount { get; set; }
    public DateTime CreatedDate { get; set; }
}