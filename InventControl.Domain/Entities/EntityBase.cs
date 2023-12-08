namespace InventControl.Domain.Entities;

public class EntityBase
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
