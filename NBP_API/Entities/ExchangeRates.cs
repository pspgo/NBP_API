using Newtonsoft.Json;

namespace NBP_API.Entities
{
    public class ExchangeRates
    {
        public int Id { get; set; }

        [JsonProperty("table")]
        public string Table { get; set; }

        [JsonProperty("no")]
        public string No { get; set; }

        [JsonProperty("tradingDate")]
        public string? TradingDate { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }       
        public virtual List<Rate> rates { get; set; }

        public virtual Rate2 rates2 { get; set; }
    }
}
