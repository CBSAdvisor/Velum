using System.Threading.Tasks;
using Velum.Web.Models;
using Velum.Web.NbrbApi.Models;

namespace Velum.Web.NbrbApi
{
    public interface INbrbApiClient
    {
        Task<ApiCurrencyDto[]> GetCurrencies();
    }
}