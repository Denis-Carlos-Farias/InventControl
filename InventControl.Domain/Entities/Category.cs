namespace InventControl.Domain.Entities;

public class Category: EntityBase
{
    public string CategoryName { get; set; }
    public bool Avalible { get; set; } = true;
}
