using System.ComponentModel.DataAnnotations;

namespace SegmentSoTCSharp.Models;

public class User
{
    [Key]
    public int UserId { get; set; }
    public virtual ICollection<UserTrait>? UserTraits { get; set; }
}