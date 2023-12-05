namespace SignalRFastFood.Dto.BookingDtos;

public class ResultBookingDto
{
    public int Id { get; set; }
    public string NameSurname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public byte PersonCount { get; set; }
    public DateTime CreatedDate { get; set; }
}