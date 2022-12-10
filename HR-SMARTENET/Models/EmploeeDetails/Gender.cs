using System.ComponentModel.DataAnnotations;

namespace HR_SMARTENET.Models.EmploeeDetails
{
    public class Gender
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string GenderType { get; set; }
    }
}
