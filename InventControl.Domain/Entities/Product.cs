namespace InventControl.Domain.Entities;

public class Product: EntityBase
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public long Quantity { get; set; }
    public int Discount { get; set; }
    public long CategoryId { get; set; }
    public Category? Category { get; set; }
}
