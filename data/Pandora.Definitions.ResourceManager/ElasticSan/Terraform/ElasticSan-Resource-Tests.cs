using System.Collections.Generic;
using Pandora.Definitions.Helpers;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.ElasticSan.Terraform;

public class ElasticSanResourceTests : TerraformResourceTestDefinition
{
    // TODO: output real tests
    public string BasicTestConfig => @"
         
resource 'azurerm_elastic_san' 'test' {
  base_size_tib              = 15
  extended_capacity_size_tib = 15
  location                   = azurerm_resource_group.test.location
  name                       = 'acctest-${local.random_integer}'
  resource_group_name        = azurerm_resource_group.test.name

  sku {
    name = 'acctest-${local.random_integer}'
  }

}


    ".AsTerraformTestConfig();

    public string RequiresImportConfig => @"
         
resource 'azurerm_elastic_san' 'import' {
  base_size_tib              = 15
  extended_capacity_size_tib = 15
  location                   = azurerm_resource_group.test.location
  name                       = 'acctest-${local.random_integer}'
  resource_group_name        = azurerm_resource_group.test.name

  sku {
    name = 'acctest-${local.random_integer}'
  }

}


    ".AsTerraformTestConfig();

    public string? CompleteConfig => @"

resource 'azurerm_elastic_san' 'test' {
  base_size_tib              = 15
  extended_capacity_size_tib = 15
  location                   = azurerm_resource_group.test.location
  name                       = 'acctest-${local.random_integer}'
  resource_group_name        = azurerm_resource_group.test.name

  sku {
    name = 'acctest-${local.random_integer}'
    tier = 'foo'
  }

  tags = {
    env  = 'Production'
    test = 'Acceptance'
  }

  zones = ['foo', 'baz']

}


	".AsTerraformTestConfig();
    public string? TemplateConfig => @"
        resource 'azurerm_foo' 'bar' {
        }
    ".AsTerraformTestConfig();

    public Dictionary<string, List<string>> OtherTests => new Dictionary<string, List<string>>();
}