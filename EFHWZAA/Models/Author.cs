namespace EFHWZAA.Models;

public class Author : BaseEntity
{
    public string FisrtName { get; set; }
    public string LastName { get; set; }
    public List<Book> Books { get; set; }
}
