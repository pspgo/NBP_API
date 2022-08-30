using AutoMapper;
using NBP_API.Entities;
using NBP_API.Models;

namespace NBP_API
{
    public class ExchangeRatesMappingProfile : Profile
    {
        public ExchangeRatesMappingProfile()
        {
            CreateMap<ExchangeRates, ExchangeRatesDto>()
                .ForMember(m => m.EffectiveDate, e => e.MapFrom(r => r.EffectiveDate));

            CreateMap<Rate, RateDto>()
                .ForMember(m => m.Code, e => e.MapFrom(r => r.Code))
                .ForMember(m => m.Mid, e => e.MapFrom(r => r.Mid));

            //CreateMap<ExchangeRates, Rate2>()
            //    .ForMember(m => m.THB, e => e.MapFrom(r => r.rates
            //    .Where(c => c.Code.ToLower() == "thb")
            //    .Select(c => c.Mid).First()))
            //    .ForMember(m => m.USD, e => e.MapFrom(r => r.rates
            //    .Where(c => c.Code.ToLower() == "usd")
            //    .Select(c => c.Mid).First()))
            //    .ForMember(m => m.AUD, e => e.MapFrom(r => r.rates
            //    .Where(c => c.Code.ToLower() == "aud")
            //    .Select(c => c.Mid).First()))
            //    .ForMember(m => m.HKD, e => e.MapFrom(r => r.rates
            //    .Where(c => c.Code.ToLower() == "hkd")
            //    .Select(c => c.Mid).First()));

        }
    }
}
