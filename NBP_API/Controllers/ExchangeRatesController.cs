using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NBP_API.Entities;
using NBP_API.Models;
using NBP_API.Services;
using Newtonsoft.Json;

namespace NBP_API.Controllers
{
    [Route("api/exchangeRates")]
    public class ExchangeRatesController : ControllerBase
    {
        private readonly IExchangeRatesService _exchangeRatesService;  

        public ExchangeRatesController(IExchangeRatesService exchangeRatesService)
        {
            _exchangeRatesService = exchangeRatesService;
        }

        [HttpGet("{table}")]
        public async Task<ActionResult> GetAll([FromRoute] string table) 
        {
            var exchangeRates = await _exchangeRatesService.GetAll(table);              

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _exchangeRatesService.SaveToDb(exchangeRates);
            var exchangeRatesDto = _exchangeRatesService.ReturnValues(exchangeRates);

            return Ok(exchangeRatesDto);                       
        }
    }
}
