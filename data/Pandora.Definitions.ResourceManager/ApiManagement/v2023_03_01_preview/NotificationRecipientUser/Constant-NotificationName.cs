using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.ApiManagement.v2023_03_01_preview.NotificationRecipientUser;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum NotificationNameConstant
{
    [Description("AccountClosedPublisher")]
    AccountClosedPublisher,

    [Description("BCC")]
    BCC,

    [Description("NewApplicationNotificationMessage")]
    NewApplicationNotificationMessage,

    [Description("NewIssuePublisherNotificationMessage")]
    NewIssuePublisherNotificationMessage,

    [Description("PurchasePublisherNotificationMessage")]
    PurchasePublisherNotificationMessage,

    [Description("QuotaLimitApproachingPublisherNotificationMessage")]
    QuotaLimitApproachingPublisherNotificationMessage,

    [Description("RequestPublisherNotificationMessage")]
    RequestPublisherNotificationMessage,
}
