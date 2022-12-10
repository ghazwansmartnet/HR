using System.ComponentModel.DataAnnotations;

namespace HR_SMARTENET.Models.EmploeeDetails
{
    public class BloodType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string bloodType { get; set; }
    }
}
