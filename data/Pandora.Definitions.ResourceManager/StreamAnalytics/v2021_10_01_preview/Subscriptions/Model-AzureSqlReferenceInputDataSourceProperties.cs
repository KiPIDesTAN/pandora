using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.StreamAnalytics.v2021_10_01_preview.Subscriptions;


internal class AzureSqlReferenceInputDataSourcePropertiesModel
{
    [JsonPropertyName("authenticationMode")]
    public AuthenticationModeConstant? AuthenticationMode { get; set; }

    [JsonPropertyName("database")]
    public string? Database { get; set; }

    [JsonPropertyName("deltaSnapshotQuery")]
    public string? DeltaSnapshotQuery { get; set; }

    [JsonPropertyName("fullSnapshotQuery")]
    public string? FullSnapshotQuery { get; set; }

    [JsonPropertyName("password")]
    public string? Password { get; set; }

    [JsonPropertyName("refreshRate")]
    public string? RefreshRate { get; set; }

    [JsonPropertyName("refreshType")]
    public RefreshTypeConstant? RefreshType { get; set; }

    [JsonPropertyName("server")]
    public string? Server { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}