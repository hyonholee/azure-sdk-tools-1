﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManagement.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.ResourceManagement.ResourceGroupDeployments
{
    /// <summary>
    /// Validate a template to see whether it's using the right syntax, resource providers, resource types, etc.
    /// </summary>
    [Cmdlet(VerbsDiagnostic.Test, "AzureResourceGroupTemplate", DefaultParameterSetName = BaseParameterSetName), OutputType(typeof(bool))]
    public class TestAzureResourceGroupTemplateCommand : ResourceWithParameterBaseCmdlet, IDynamicParameters
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The resource group name.")]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        public override void ExecuteCmdlet()
        {
            ValidatePSResourceGroupDeploymentParameters parameters = new ValidatePSResourceGroupDeploymentParameters()
            {
                ResourceGroupName = ResourceGroupName,
                GalleryTemplateName = GalleryTemplateName,
                TemplateFile = this.TryResolvePath(TemplateFile),
                ParameterObject = GetParameterObject(ParameterObject),
                TemplateVersion = TemplateVersion,
                TemplateHash = TemplateHash,
                TemplateHashAlgorithm = TemplateHashAlgorithm,
                StorageAccountName = StorageAccountName,
            };

            WriteObject(ResourceClient.ValidatePSResourceGroupDeployment(parameters));
        }
    }
}
