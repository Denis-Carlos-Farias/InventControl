﻿namespace InventControl.Application.DTO;

public class ProductDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public long Quantity { get; set; }
    public int Discount { get; set; }
    public long CategoryId { get; set; }
}
