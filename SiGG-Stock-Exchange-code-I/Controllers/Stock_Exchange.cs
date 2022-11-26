using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.AspNetCore.Authorization;
=======
>>>>>>> main

namespace SiGG_Stock_Exchange_code_I.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Stock_Exchange : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
<<<<<<< HEAD
        "Freezing", "Bracing"
    };

        private readonly ILogger<Stock_Exchange> _logger;
        private object _userService;
=======
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<Stock_Exchange> _logger;
>>>>>>> main

        public Stock_Exchange(ILogger<Stock_Exchange> logger)
        {
            _logger = logger;
        }

<<<<<<< HEAD
   
        [HttpGet(Name = "GetStockExchange")]
        public IEnumerable<Stock_Exchange_code_I> GetType() => Enumerable.Range(1, 5).Select(index => new Stock_Exchange_code_I
        {
            siGpConsCode = "",
            siGpIsin = "",
            siGpCusip = "",
            siGpSedol = "",
            siGpConstituentName = "",
            siGpCountryCode = "",
            siGpCurrencyCode = "",
            siGpMtcExchangeCode = "",
            siGpPrice = "",
            siGpSharesInIssue = "",
            siGpWeighting = "",
            siGpIndustryCode = "",
            siGpSuperSectorCode = "",
            siGpSectorCode = "",
            siGpSubSectorCode = "",
            siGpPctWtEpraEuUkResIndex = "",
            siGpPctWtEpraEuExUkIndex = "",
            siGpPctWtEpraEuL40ExUkIndex = "",
            siGpPctWtEpraEuL40Index = "",
            siGpPctWtEpraAsiaIndex = "",
            siGpPctWtEpraPureAsiaIndex = "",
            siGpPctWtEpraNaIndex = "",
            siGpPctWtCountryIndex = "",
            siGpIndexMarker = "",
            siGpCompanyId = "",
            siGpCompanyName = "",
            siGpYear = "",
            siGpQuarter = "",
            siGpRevenueTotalUsd = "",
            siGpRevenueTotalLocal = "",
            siGpTotalAsserts = "",
            siGpTotalAssertsGreen = "",
            siGpTotalPercentGreen = "",
            siGpSqmAsserts = "",
            siGpSqmAssertsGreen = "",
            siGpSqmPercentGreen = "",
            siGpCarbanTotal = "",
            siGpCarbanSqm = "",
            siGpEnergyTotal = "",
            siGpEnergySqm = "",
            sigpConstituentNew = "",
            startDate = "",
            endDate = "",
            secondDateCsSecondDate = "",
            activeFlag = "",
            sourceFileName = "",
            fileLoadDateTime = "",
            fileProcessYear = "",
            fileProcessMonth = "",

        })
            .ToArray();

        
    }


    

}

=======
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
>>>>>>> main
