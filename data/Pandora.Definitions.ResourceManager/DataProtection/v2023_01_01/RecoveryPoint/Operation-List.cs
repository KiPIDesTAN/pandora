using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.DataProtection.v2023_01_01.RecoveryPoint;

internal class ListOperation : Operations.ListOperation
{
    public override string? FieldContainingPaginationDetails() => "nextLink";

    public override ResourceID? ResourceId() => new BackupInstanceId();

    public override Type NestedItemType() => typeof(AzureBackupRecoveryPointResourceModel);

    public override Type? OptionsObject() => typeof(ListOperation.ListOptions);

    public override string? UriSuffix() => "/recoveryPoints";

    internal class ListOptions
    {
        [QueryStringName("$filter")]
        [Optional]
        public string Filter { get; set; }
    }
}
