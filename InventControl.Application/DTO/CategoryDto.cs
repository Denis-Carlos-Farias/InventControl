namespace InventControl.Application.DTO;

public class CategoryDto
{
    public long Id { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public bool Avalible { get; set; }
}
