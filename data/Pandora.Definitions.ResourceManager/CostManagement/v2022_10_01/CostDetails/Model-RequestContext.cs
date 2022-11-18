using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CostManagement.v2022_10_01.CostDetails;


internal class RequestContextModel
{
    [JsonPropertyName("requestBody")]
    public GenerateCostDetailsReportRequestDefinitionModel? RequestBody { get; set; }

    [JsonPropertyName("requestScope")]
    public string? RequestScope { get; set; }
}