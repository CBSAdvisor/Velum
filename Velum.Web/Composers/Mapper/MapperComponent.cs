using Umbraco.Core.Composing;
using Umbraco.Core.Logging;

namespace Velum.Web.Composers.Mapper
{
    public class MapperComponent : IComponent
    {
        private readonly ILogger _logger;

        public MapperComponent(
            ILogger logger)
        {
            _logger = logger;
        }

        public void Initialize()
        {
        }

        public void Terminate()
        {
        }
    }
}