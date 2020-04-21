using Umbraco.Core;
using Umbraco.Core.Composing;
using Velum.Web.Domain.CurrencyRates;
using Velum.Web.NbrbApi;

namespace Velum.Web.Composers
{
    public class RegisterServiceComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<INbrbApiClient, NbrbApiClient>(Lifetime.Request);
            composition.Register<ICurrencyRatesManager, CurrencyRatesManager>(Lifetime.Request);
        }
    }
}