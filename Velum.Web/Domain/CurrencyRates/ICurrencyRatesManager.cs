using System.Threading.Tasks;

namespace Velum.Web.Domain.CurrencyRates
{
    public interface ICurrencyRatesManager
    {
        Task LoadAndSaveCurrencies();
    }
}