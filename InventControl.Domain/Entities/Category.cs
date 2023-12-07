namespace InventControl.Domain.Entities;

public class Category: Base
{
    public string CategoryName { get; set; }
    public bool Avalible { get; set; } = true;
}
