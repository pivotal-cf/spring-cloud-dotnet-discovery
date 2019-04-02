﻿//
// Copyright 2015 the original author or authors.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Steeltoe.Discovery.Eureka;
using System;

namespace Pivotal.Discovery.Client.Test
{
    public abstract class AbstractBaseTest
    {
        public AbstractBaseTest()
        {
            Environment.SetEnvironmentVariable("VCAP_APPLICATION", null);
            Environment.SetEnvironmentVariable("VCAP_SERVICES", null);
            Environment.SetEnvironmentVariable("CF_INSTANCE_INDEX", null);
            Environment.SetEnvironmentVariable("CF_INSTANCE_GUID", null);
            ApplicationInfoManager.Instance.InstanceInfo = null;
            ApplicationInfoManager.Instance.InstanceConfig = null;
            DiscoveryManager.Instance.ClientConfig = null;
            DiscoveryManager.Instance.Client = null;
            DiscoveryManager.Instance.InstanceConfig = null;
        }
    }
}
