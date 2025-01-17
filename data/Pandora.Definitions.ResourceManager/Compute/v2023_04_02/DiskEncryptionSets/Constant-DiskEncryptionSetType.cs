using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Compute.v2023_04_02.DiskEncryptionSets;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DiskEncryptionSetTypeConstant
{
    [Description("ConfidentialVmEncryptedWithCustomerKey")]
    ConfidentialVMEncryptedWithCustomerKey,

    [Description("EncryptionAtRestWithCustomerKey")]
    EncryptionAtRestWithCustomerKey,

    [Description("EncryptionAtRestWithPlatformAndCustomerKeys")]
    EncryptionAtRestWithPlatformAndCustomerKeys,
}
