namespace InventControl.Domain.Entities;

public class Base
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
