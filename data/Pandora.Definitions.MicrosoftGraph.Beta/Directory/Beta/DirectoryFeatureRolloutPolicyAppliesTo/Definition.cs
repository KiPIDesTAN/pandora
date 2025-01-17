// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.Beta.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.Beta.Directory.Beta.DirectoryFeatureRolloutPolicyAppliesTo;

internal class Definition : ResourceDefinition
{
    public string Name => "DirectoryFeatureRolloutPolicyAppliesTo";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new AddDirectoryFeatureRolloutPolicyByIdAppliesToRefOperation(),
        new CreateDirectoryFeatureRolloutPolicyByIdAppliesToOperation(),
        new GetDirectoryFeatureRolloutPolicyByIdAppliesToCountOperation(),
        new ListDirectoryFeatureRolloutPolicyByIdAppliesToRefsOperation(),
        new ListDirectoryFeatureRolloutPolicyByIdAppliesTosOperation(),
        new RemoveDirectoryFeatureRolloutPolicyByIdAppliesToByIdRefOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
