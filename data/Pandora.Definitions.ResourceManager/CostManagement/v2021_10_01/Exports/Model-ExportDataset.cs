using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.Exports
{

    internal class ExportDatasetModel
    {
        [JsonPropertyName("configuration")]
        public ExportDatasetConfigurationModel? Configuration { get; set; }

        [JsonPropertyName("granularity")]
        public GranularityTypeConstant? Granularity { get; set; }
    }
}
