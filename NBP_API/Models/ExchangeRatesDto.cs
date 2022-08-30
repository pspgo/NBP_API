using System.ComponentModel.DataAnnotations;

namespace NBP_API.Models
{
    public class ExchangeRatesDto
    {
        public int Id { get; set; }

        [Required]
        public string EffectiveDate { get; set; }
        public List<RateDto> Rates { get; set; }
    }
}
