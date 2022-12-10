using System.ComponentModel.DataAnnotations;

namespace HR_SMARTENET.Models.EmploeeDetails
{
    public class Nationality
    {
        [Key]
        public int Id { get; set; }
        public string nationality { get; set; }
    }
}
