﻿// ----------------------------------------------------------------------------------
//
// Copyright 2011 Microsoft Corporation
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

namespace Microsoft.WindowsAzure.Management.CloudService.Scaffolding
{
    using System.Collections.Generic;
    using Model;
    using ServiceConfigurationSchema;
    using ServiceDefinitionSchema;
    using Utilities;

    public static class NodeRules
    {
        public static void AddRoleToConfig(string path, Dictionary<string, object> parameters)
        {
            RoleInfo role = parameters["Role"] as RoleInfo;
            ServiceComponents components = parameters["Components"] as ServiceComponents;
            ServicePathInfo paths = parameters["Paths"] as ServicePathInfo;
            RoleSettings settings = General.DeserializeXmlFile<ServiceConfiguration>(path).Role[0];

            components.AddRoleToConfiguration(settings, DevEnv.Cloud);
            components.AddRoleToConfiguration(settings, DevEnv.Local);
            components.Save(paths);
        }

        public static void AddWebRoleToDef(string path, Dictionary<string, object> parameters)
        {
            RoleInfo role = parameters["Role"] as RoleInfo;
            ServiceComponents components = parameters["Components"] as ServiceComponents;
            ServicePathInfo paths = parameters["Paths"] as ServicePathInfo;
            WebRole webRole = General.DeserializeXmlFile<ServiceDefinition>(path).WebRole[0];

            role.AddRoleToDefinition(components.Definition, webRole);
            components.Save(paths);
        }

        public static void AddWorkerRoleToDef(string path, Dictionary<string, object> parameters)
        {
            RoleInfo role = parameters["Role"] as RoleInfo;
            ServiceComponents components = parameters["Components"] as ServiceComponents;
            ServicePathInfo paths = parameters["Paths"] as ServicePathInfo;
            WorkerRole workerRole = General.DeserializeXmlFile<ServiceDefinition>(path).WorkerRole[0];

            role.AddRoleToDefinition(components.Definition, workerRole);
            components.Save(paths);
        }
    }
}