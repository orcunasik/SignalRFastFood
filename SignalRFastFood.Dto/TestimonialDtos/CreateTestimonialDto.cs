﻿namespace SignalRFastFood.Dto.TestimonialDtos;

public class CreateTestimonialDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Comment { get; set; }
    public string ImageUrl { get; set; }
    public bool IsStatus { get; set; }
}