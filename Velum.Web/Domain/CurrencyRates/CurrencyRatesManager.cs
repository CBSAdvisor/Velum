using System.Threading.Tasks;
using NPoco;
using Umbraco.Core.Mapping;
using Umbraco.Core.Scoping;
using Velum.Web.NbrbApi;
using Velum.Web.NbrbApi.Models;
using NPoco.Linq;
using System.Linq;
using Umbraco.Core;
using Umbraco.Core.Persistence;

namespace Velum.Web.Domain.CurrencyRates
{
    public class CurrencyRatesManager : ICurrencyRatesManager
    {
        private readonly INbrbApiClient _nbrbApiClient;
        private readonly IScopeProvider _scopeProvider;
        private readonly UmbracoMapper _mapper;

        public CurrencyRatesManager(
            INbrbApiClient nbrbApiClient,
            IScopeProvider scopeProvider,
            UmbracoMapper mapper)
        {
            _nbrbApiClient = nbrbApiClient;
            _scopeProvider = scopeProvider;
            _mapper = mapper;
        }

        public async Task LoadAndSaveCurrencies()
        {
            var currencies = await _nbrbApiClient.GetCurrencies();
            using (var scope = _scopeProvider.CreateScope())
            {
                scope.Database.BeginTransaction();

                await scope.Database.DeleteMany<Currency>().ExecuteAsync();
                scope.Database.InsertBatch(_mapper.MapEnumerable<ApiCurrencyDto, Currency>(currencies));

                scope.Database.CompleteTransaction();
                scope.Complete();
            }
        }

        public async Task GetCurrencies()
        {
            using (var scope = _scopeProvider.CreateScope())
            {
                scope.Database.BeginTransaction();

                var query = scope.Database.SqlContext.Sql().Select("*").From<Currency>();
                scope.Database.Query<Currency>(query);

                scope.Complete();
            }
        }
    }
}