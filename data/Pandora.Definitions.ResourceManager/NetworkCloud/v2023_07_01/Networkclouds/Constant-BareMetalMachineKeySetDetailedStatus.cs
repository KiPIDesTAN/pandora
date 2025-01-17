using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.NetworkCloud.v2023_07_01.Networkclouds;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum BareMetalMachineKeySetDetailedStatusConstant
{
    [Description("AllActive")]
    AllActive,

    [Description("AllInvalid")]
    AllInvalid,

    [Description("SomeInvalid")]
    SomeInvalid,

    [Description("Validating")]
    Validating,
}
