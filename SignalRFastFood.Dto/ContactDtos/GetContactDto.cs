﻿namespace SignalRFastFood.Dto.ContactDtos;

public class GetContactDto
{
    public int Id { get; set; }
    public string LocationUrl { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string FooterDescription { get; set; }
}