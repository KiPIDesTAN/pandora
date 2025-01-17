using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Workloads.v2023_04_01.SAPApplicationServerInstances;

internal class Definition : ResourceDefinition
{
    public string Name => "SAPApplicationServerInstances";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListOperation(),
        new StartInstanceOperation(),
        new StopInstanceOperation(),
        new UpdateOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ApplicationServerVirtualMachineTypeConstant),
        typeof(SAPHealthStateConstant),
        typeof(SAPVirtualInstanceStatusConstant),
        typeof(SapVirtualInstanceProvisioningStateConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(ApplicationServerVMDetailsModel),
        typeof(ErrorAdditionalInfoModel),
        typeof(ErrorDefinitionModel),
        typeof(ErrorDetailModel),
        typeof(LoadBalancerDetailsModel),
        typeof(OperationStatusResultModel),
        typeof(SAPApplicationServerInstanceModel),
        typeof(SAPApplicationServerPropertiesModel),
        typeof(SAPVirtualInstanceErrorModel),
        typeof(StopRequestModel),
        typeof(StorageInformationModel),
        typeof(UpdateSAPApplicationInstanceRequestModel),
    };
}
