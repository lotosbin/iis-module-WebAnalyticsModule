//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Management.Server;
using Microsoft.Web.Administration;

namespace WebAnalyticsModule
{
    class WebAnalyticsService : ModuleService
    {
        internal WebAnalyticsSection GetWebAnalyticsSection()
        {
            WebAnalyticsSection section = (WebAnalyticsSection)ManagementUnit.Configuration.GetSection("system.webServer/webAnalytics", typeof(WebAnalyticsSection));
            
            if (section == null)
            {
                RaiseException("Failed to read configuration section system.webServer/webAnalytics.");
            }

            return section;
        }

        [ModuleServiceMethod(PassThrough = true)]
        public PropertyBag GetWebAnalyticsSettings()
        {
            PropertyBag bag = new PropertyBag();

            WebAnalyticsSection configSection = GetWebAnalyticsSection();
 
            bag[WebAnalyticsGlobals.trackingEnabled] = configSection.TrackingEnabled;
            bag[WebAnalyticsGlobals.trackingScript] = configSection.TrackingScript;
            bag[WebAnalyticsGlobals.insertionPoint] = configSection.InsertionPoint;
            bag[WebAnalyticsGlobals.isLocked] = configSection.IsLocked;
            
            return bag;
        }

        [ModuleServiceMethod(PassThrough = true)]
        public void UpdateWebAnalyticsSettings(PropertyBag bag)
        {
            WebAnalyticsSection configSection = GetWebAnalyticsSection();

            configSection.TrackingEnabled = (bool)bag[WebAnalyticsGlobals.trackingEnabled];
            configSection.TrackingScript = (string)bag[WebAnalyticsGlobals.trackingScript];
            configSection.InsertionPoint = (InsertionPoint)bag[WebAnalyticsGlobals.insertionPoint];

            ManagementUnit.Update();
        }
    }
}
