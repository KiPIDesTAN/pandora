using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.DataBricks.v2021_04_01_preview.DELETE
{
    internal class Definition : ApiDefinition
    {
        public string ApiVersion => "2021-04-01-preview";
        public string Name => "DELETE";
        public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
        {
            new PrivateEndpointConnectionsDeleteOperation(),
        };
    }
}
