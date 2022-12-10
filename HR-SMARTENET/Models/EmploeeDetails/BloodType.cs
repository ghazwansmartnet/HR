using System.ComponentModel.DataAnnotations;

namespace HR_SMARTENET.Models.EmploeeDetails
{
    public class BloodType
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
