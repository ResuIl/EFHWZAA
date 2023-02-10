using EFHWZAA.Enums;
using System.Reflection;

namespace EFHWZAA.Models;

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public short SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public List<Book> Books { get; set; }
}
