﻿namespace InventControl.Domain.DTO;

public class ProductDto
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public long Quantity { get; set; }
    public int Discount { get; set; }
    public long CategoryId { get; set; }
}
