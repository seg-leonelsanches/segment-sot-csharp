using System.ComponentModel.DataAnnotations;

namespace SegmentSoTCSharp.Models;

public class UserTrait {
    [Key]
    public Guid UserTraitId { get; set; }
    public int UserId { get; set; }

    public string? TraitName { get; set; }
    public string? TraitValue { get; set; }

    public virtual User? User { get; set; }
}