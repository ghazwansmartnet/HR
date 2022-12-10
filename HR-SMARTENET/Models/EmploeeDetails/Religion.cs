using System.ComponentModel.DataAnnotations;

namespace HR_SMARTENET.Models.EmploeeDetails
{
    public class Religion
    {
        [Key]
        public int Id { get; set; }
        public string religion { get; set; }
    }
}
