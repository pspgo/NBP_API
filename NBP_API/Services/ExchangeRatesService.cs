using AutoMapper;
using NBP_API.Entities;
using NBP_API.Models;
using Newtonsoft.Json;
using System.Reflection;

namespace NBP_API.Services
{
    public interface IExchangeRatesService
    {
        Task<List<ExchangeRates>> GetAll(string table);
        void SaveToDb(List<ExchangeRates> exchangeRates);
        public List<ExchangeRatesDto> ReturnValues(List<ExchangeRates> exchangeRates);
    }

    public class ExchangeRatesService : IExchangeRatesService
    {
        private readonly ExchangeRatesDbContext _dbContext;
        private readonly IMapper _mapper;

        public ExchangeRatesService(ExchangeRatesDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ExchangeRates>> GetAll(string table)
        {
            string url = $"https://api.nbp.pl/api/exchangerates/tables/{table}";

            HttpClient httpClient = new HttpClient();

            var httpResponseMessage = await httpClient.GetAsync(url);

            string jsonResponse = await httpResponseMessage.Content.ReadAsStringAsync();

            var exchangeRatesResult = JsonConvert.DeserializeObject<List<ExchangeRates>>(jsonResponse);

            return exchangeRatesResult;
        }

        public void SaveToDb(List<ExchangeRates> exchangeRates)
        {
            exchangeRates[0].rates2 = ConvertToRate2(exchangeRates[0].rates);

            _dbContext.ExchangeRates.Add(exchangeRates[0]);
            _dbContext.SaveChanges();
        }

        private Rate2 ConvertToRate2(List<Rate> rates)
        {
            Rate2 r2 = new Rate2();

            foreach (Rate rate in rates)
            {
                foreach (PropertyInfo prop in r2.GetType().GetProperties())
                {
                    var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    if (type == typeof(string))
                    {
                        if (rate.Code == prop.Name)
                            prop.SetValue(r2, rate.Mid);                       
                    }
                }
            }
            return r2;
        }

        public List<ExchangeRatesDto> ReturnValues(List<ExchangeRates> exchangeRates)
        {
            return _mapper.Map<List<ExchangeRatesDto>>(exchangeRates);
        }
    }
}
