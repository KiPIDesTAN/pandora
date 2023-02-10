using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.CosmosDB.v2022_11_15.CosmosDB;

internal class DatabaseAccountNameId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/providers/Microsoft.DocumentDB/databaseAccountNames/{databaseAccountNameName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftDocumentDB", "Microsoft.DocumentDB"),
        ResourceIDSegment.Static("staticDatabaseAccountNames", "databaseAccountNames"),
        ResourceIDSegment.UserSpecified("databaseAccountNameName"),
    };
}