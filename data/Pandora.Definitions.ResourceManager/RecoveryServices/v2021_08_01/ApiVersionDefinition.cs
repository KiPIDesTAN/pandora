using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.RecoveryServices.v2021_08_01;

public partial class Definition : ApiVersionDefinition
{
    public string ApiVersion => "2021-08-01";
    public bool Preview => false;
    public Source Source => Source.ResourceManagerRestApiSpecs;

    public IEnumerable<ResourceDefinition> Resources => new List<ResourceDefinition>
    {
        new GetPrivateLinkResources.Definition(),
        new ListPrivateLinkResources.Definition(),
        new RecoveryServices.Definition(),
        new RegisteredIdentities.Definition(),
        new ReplicationUsages.Definition(),
        new VaultCertificates.Definition(),
        new VaultExtendedInfo.Definition(),
        new VaultUsages.Definition(),
        new Vaults.Definition(),
    };
}