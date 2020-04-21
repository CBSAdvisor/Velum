using Umbraco.Core.Mapping;
using Velum.Web.Domain.CurrencyRates;
using Velum.Web.NbrbApi.Models;

namespace Velum.Web.Composers.Mapper
{
    public class CurrencyMapDefinition : IMapDefinition
    {
        public void DefineMaps(UmbracoMapper mapper)
        {
            mapper.Define<ApiCurrencyDto, Currency>(
                (source, context) => new Currency(),
                (source, target, context) =>
                {
                    target.Id = source.Id;
                    target.ParentId = source.ParentId;
                    target.Code = source.Code;
                    target.Abbreviation = source.Abbreviation;
                    target.Name = source.Name;
                    target.NameBel = source.NameBel;
                    target.NameEng = source.NameEng;
                    target.QuotName = source.QuotName;
                    target.QuotNameBel = source.QuotNameBel;
                    target.QuotNameEng = source.QuotNameEng;
                    target.NameMulti = source.NameMulti;
                    target.NameBelMulti = source.NameBelMulti;
                    target.NameEngMulti = source.NameEngMulti;
                    target.Scale = source.Scale;
                    target.Periodicity = source.Periodicity;
                    target.DateStart = source.DateStart;
                    target.DateEnd = source.DateEnd;
                }
            );
        }
    }
}