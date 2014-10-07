//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Management.Server;

namespace WebAnalyticsModule
{
    class WebAnalyticsProvider : ModuleProvider
    {
        public override ModuleDefinition GetModuleDefinition(IManagementContext context)
        {
            return new ModuleDefinition(Name, typeof(WebAnalyticsModule).AssemblyQualifiedName);
        }

        public override Type ServiceType
        {
            get { return typeof(WebAnalyticsService); }
        }

        public override bool SupportsScope(ManagementScope scope)
        {
            return true;
        }
    }
}
