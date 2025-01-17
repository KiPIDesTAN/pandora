// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.MicrosoftGraph.Beta.RoleManagement.Beta.RoleManagementCloudPCRoleAssignmentDirectoryScope;

internal class RoleManagementCloudPCRoleAssignmentIdDirectoryScopeId : ResourceID
{
    public string? CommonAlias => null;
    public string ID => "/roleManagement/cloudPC/roleAssignments/{unifiedRoleAssignmentMultipleId}/directoryScopes/{directoryObjectId}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticRoleManagement", "roleManagement"),
        ResourceIDSegment.Static("staticCloudPC", "cloudPC"),
        ResourceIDSegment.Static("staticRoleAssignments", "roleAssignments"),
        ResourceIDSegment.UserSpecified("unifiedRoleAssignmentMultipleId"),
        ResourceIDSegment.Static("staticDirectoryScopes", "directoryScopes"),
        ResourceIDSegment.UserSpecified("directoryObjectId")
    };
}
