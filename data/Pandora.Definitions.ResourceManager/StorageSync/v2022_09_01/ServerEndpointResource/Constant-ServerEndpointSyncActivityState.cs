using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.StorageSync.v2022_09_01.ServerEndpointResource;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum ServerEndpointSyncActivityStateConstant
{
    [Description("Download")]
    Download,

    [Description("Upload")]
    Upload,

    [Description("UploadAndDownload")]
    UploadAndDownload,
}
