using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.GenerateDetailedCostReportOperationStatus
{

    internal class DownloadURLModel
    {
        [JsonPropertyName("downloadUrl")]
        public string? DownloadUrl { get; set; }

        [DateFormat(DateFormatAttribute.DateFormat.RFC3339)]
        [JsonPropertyName("validTill")]
        public DateTime? ValidTill { get; set; }
    }
}
