using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Umbraco.Core.Mapping;
using Umbraco.Core.Scoping;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;
using Velum.Web.Domain.CurrencyRates;
using Velum.Web.Models;
using Velum.Web.NbrbApi;
using Velum.Web.NbrbApi.Models;

namespace Velum.Web.Controllers
{
    public class InvestmentPortfolioController : RenderMvcController
    {
        private readonly INbrbApiClient _nbrbApiClient;
        private readonly ICurrencyRatesManager _currencyRatesManager;
        private readonly IScopeProvider _scopeProvider;
        private readonly UmbracoMapper _mapper;

        public InvestmentPortfolioController(
            INbrbApiClient nbrbApiClient,
            ICurrencyRatesManager currencyRatesManager,
            IScopeProvider scopeProvider,
            UmbracoMapper mapper)
        {
            _nbrbApiClient = nbrbApiClient;
            _currencyRatesManager = currencyRatesManager;
            _scopeProvider = scopeProvider;
            _mapper = mapper;
        }

        // GET: InvestmentPortfolio
        public async Task<ActionResult> Index(ContentModel model)
        {
            await _currencyRatesManager.LoadAndSaveCurrencies();

            var currencies = await _nbrbApiClient.GetCurrencies();
            ViewData["Currencies"] = _mapper.MapEnumerable<ApiCurrencyDto, Currency>(currencies);

            //using (var scope = _scopeProvider.CreateScope())
            //{
            //    //Always complete scope
            //    scope.Database.Insert(currencies[0]);
            //    scope.Complete();
            //}

            return base.Index(model);
        }
    }
}