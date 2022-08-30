using Newtonsoft.Json;

namespace NBP_API.Entities
{
    public class Rate
    {
        public int Id { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("mid")]
        public string Mid { get; set; }
        public int ExchangeRatesId { get; set; }
        public virtual ExchangeRates ExchangeRates { get; set; }
    }
}
