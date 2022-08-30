using NBP_API.Entities;

namespace NBP_API
{
    public class ExchangeRatesSeeder
    {
        private readonly ExchangeRatesDbContext _dbContext;
        public ExchangeRatesSeeder(ExchangeRatesDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Seed()
        {
            if(_dbContext.Database.CanConnect())
            {
                if(!_dbContext.ExchangeRates.Any())
                {
                    var exchangeRates = GetExchangeRates();
                    _dbContext.ExchangeRates.AddRange(exchangeRates);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<ExchangeRates> GetExchangeRates()
        {
            var exchangeRates = new List<ExchangeRates>()
            {
                new ExchangeRates()
                {
                    Table = "a",
                    No = "111/A/NBP/2022",
                    EffectiveDate = "2022-08-26",
                    rates = new List<Rate>()
                    {
                        new Rate()
                        {
                            Code = "USD",
                            Mid = "4.7465"
                        },
                        new Rate()
                        {
                            Code = "AUD",
                            Mid = "3.3055"
                        }
                    }
                },
                new ExchangeRates()
                {
                    Table = "b",
                    No = "222/A/NBP/2022",
                    EffectiveDate = "2022-08-26",
                    rates = new List<Rate>()
                    {
                        new Rate()
                        {
                            Code = "HKD",
                            Mid = "0.6049"
                        },
                        new Rate()
                        {
                            Code = "CAD",
                            Mid = "3.6653"
                        }
                    }
                }
            };
            return exchangeRates;
        }
    }
}
