using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Automation.v2022_08_08.JobStream;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum JobStreamTypeConstant
{
    [Description("Any")]
    Any,

    [Description("Debug")]
    Debug,

    [Description("Error")]
    Error,

    [Description("Output")]
    Output,

    [Description("Progress")]
    Progress,

    [Description("Verbose")]
    Verbose,

    [Description("Warning")]
    Warning,
}
