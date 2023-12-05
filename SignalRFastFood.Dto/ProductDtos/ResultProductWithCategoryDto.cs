namespace SignalRFastFood.Dto.ProductDtos;

public class ResultProductWithCategoryDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public decimal Price { get; set; }
    public bool IsStatus { get; set; }
    public string CategoryName { get; set; }
}