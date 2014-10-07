//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Server;

namespace WebAnalyticsModule
{
    class WebAnalyticsProxy : ModuleServiceProxy
    {
        public void UpdateWebAnalyticsSettings(PropertyBag bag)
        {
            Invoke("UpdateWebAnalyticsSettings", bag);
        }

        public PropertyBag GetWebAnalyticsSettings()
        {
            return (PropertyBag)Invoke("GetWebAnalyticsSettings");
        }
    }
}
