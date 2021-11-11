using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.CostManagement.v2021_10_01.Alerts
{
    internal class ScopedAlertId : ResourceID
    {
        public string? CommonAlias => null;

        public string ID => "/{scope}/providers/Microsoft.CostManagement/alerts/{alertId}";

        public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
        {
                new()
                {
                    Name = "scope",
                    Type = ResourceIDSegmentType.Scope
                },

                new()
                {
                    Name = "providers",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "providers"
                },

                new()
                {
                    Name = "microsoftCostManagement",
                    Type = ResourceIDSegmentType.ResourceProvider,
                    FixedValue = "Microsoft.CostManagement"
                },

                new()
                {
                    Name = "alerts",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "alerts"
                },

                new()
                {
                    Name = "alertId",
                    Type = ResourceIDSegmentType.UserSpecified
                },

        };
    }
}
