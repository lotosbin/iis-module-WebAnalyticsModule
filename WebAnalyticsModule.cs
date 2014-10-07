//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Management.Server;
using Microsoft.Web.Management.Client;
using System.Diagnostics;

namespace WebAnalyticsModule
{
    internal class WebAnalyticsModule : Module
    {
        protected override void Initialize(IServiceProvider serviceProvider, ModuleInfo moduleInfo)
        {
            base.Initialize(serviceProvider, moduleInfo);

            IControlPanel controlPanel = (IControlPanel)GetService(typeof(IControlPanel));
            Debug.Assert(controlPanel != null, "Couldn't get IControlPanel");

            ModulePageInfo modulePageInfo = new ModulePageInfo(this, typeof(WebAnalyticsPage), 
                                                                "Web Analytics Tracking",
                                                                "Manage Web Analytics Tracking settings", 
                                                                Resources.WebAnalyticsIcon16, 
                                                                Resources.WebAnalyticsIcon32);

            controlPanel.RegisterPage(ControlPanelCategoryInfo.Iis, modulePageInfo);
            controlPanel.RegisterPage(ControlPanelCategoryInfo.CommonHttp, modulePageInfo);
        }

        protected override bool IsPageEnabled(ModulePageInfo pageInfo)
        {
            Connection connection = (Connection)GetService(typeof(Connection));

            ICollection<string> currentBindingProtocols =
               connection.ConfigurationPath.GetBindingProtocols(this);

            // We only want the module configuration to be available on site, application of folder levels.
            return (connection.ConfigurationPath.PathType == ConfigurationPathType.Site ||
                    connection.ConfigurationPath.PathType == ConfigurationPathType.Application ||
                    connection.ConfigurationPath.PathType == ConfigurationPathType.Folder);
        }
    }
}