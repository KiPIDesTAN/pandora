using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.PolicyInsights.v2022_09_01.Attestations;

internal class AttestationsCreateOrUpdateAtSubscriptionOperation : Operations.PutOperation
{
    public override bool LongRunning() => true;

    public override Type? RequestObject() => typeof(AttestationModel);

    public override ResourceID? ResourceId() => new AttestationId();

    public override Type? ResponseObject() => typeof(AttestationModel);


}