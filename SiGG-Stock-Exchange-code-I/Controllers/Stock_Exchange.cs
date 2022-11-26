using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace SiGG_Stock_Exchange_code_I.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Stock_Exchange : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing"
    };

        private readonly ILogger<Stock_Exchange> _logger;
        private object _userService;

        public Stock_Exchange(ILogger<Stock_Exchange> logger)
        {
            _logger = logger;
        }

   
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

