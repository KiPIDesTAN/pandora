using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Kusto.v2023_08_15.Databases;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum PrincipalsModificationKindConstant
{
    [Description("None")]
    None,

    [Description("Replace")]
    Replace,

    [Description("Union")]
    Union,
}
