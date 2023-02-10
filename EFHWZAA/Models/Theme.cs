namespace EFHWZAA.Models;

public class Theme : BaseEntity
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}
