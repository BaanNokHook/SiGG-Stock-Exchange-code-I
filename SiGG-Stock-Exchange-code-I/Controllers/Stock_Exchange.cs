using Microsoft.AspNetCore.Mvc;

namespace SiGG_Stock_Exchange_code_I.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Stock_Exchange : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<Stock_Exchange> _logger;

        public Stock_Exchange(ILogger<Stock_Exchange> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetStockExchange")]
        public IEnumerable<Stock_Exchange_code_I> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Stock_Exchange_code_I
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}