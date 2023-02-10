using EFHWZAA.Enums;
namespace EFHWZAA.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public DataStatus Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? ModifiedDate { get; set; }

    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
        Status = DataStatus.Inserted;
    }
}
