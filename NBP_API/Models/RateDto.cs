using System.ComponentModel.DataAnnotations;

namespace NBP_API.Models
{
    public class RateDto
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Mid { get; set; }
    }
}
