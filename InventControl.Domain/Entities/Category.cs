namespace InventControl.Domain.Entities;

public class Category: EntityBase
{
    public required string CategoryName { get; set; }
    public bool Avalible { get; set; } = true;
}
