namespace EFHWZAA.Models;

public class Book : BaseEntity
{
    public string Name { get; set; }
    public int PageCount { get; set; }
    public int ThemeId { get; set; }
    public int? StudentId { get; set; }
    public Student Student { get; set; }
    public List<Author> Authors { get; set; }
    public Theme Theme { get; set; }
}
