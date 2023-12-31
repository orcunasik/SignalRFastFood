﻿namespace SignalRFastFood.Core.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsStatus { get; set; }
    public IList<Product> Products { get; set; }
}