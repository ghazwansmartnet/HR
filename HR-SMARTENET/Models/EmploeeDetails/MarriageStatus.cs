using System.ComponentModel.DataAnnotations;

namespace HR_SMARTENET.Models.EmploeeDetails
{
    public class MarriageStatus
    {
        [Key]
        public int Id { get; set; }
        public string marriageStatus { get; set; }
    }
}
