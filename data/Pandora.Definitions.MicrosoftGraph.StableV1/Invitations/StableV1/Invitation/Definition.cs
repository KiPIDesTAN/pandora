// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using Pandora.Definitions.Interfaces;
using Pandora.Definitions.MicrosoftGraph.StableV1.CommonTypes;
using System;

namespace Pandora.Definitions.MicrosoftGraph.StableV1.Invitations.StableV1.Invitation;

internal class Definition : ResourceDefinition
{
    public string Name => "Invitation";

    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateInvitationOperation(),
        new DeleteInvitationByIdOperation(),
        new GetInvitationByIdOperation(),
        new GetInvitationCountOperation(),
        new ListInvitationsOperation(),
        new UpdateInvitationByIdOperation()
    };

    public IEnumerable<System.Type> Constants => new List<System.Type>
    {

    };

    public IEnumerable<System.Type> Models => new List<System.Type>
    {

    };
}
