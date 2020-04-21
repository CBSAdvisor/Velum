using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Core.Mapping;
using Velum.Web.Composers.Mapper;
using Velum.Web.Domain.CurrencyRates;
using Velum.Web.NbrbApi;

namespace Velum.Web.Composers
{
    public class MapperComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.WithCollectionBuilder<MapDefinitionCollectionBuilder>()
                .Add<CurrencyMapDefinition>();
        }
    }
}