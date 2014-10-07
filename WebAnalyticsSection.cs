//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Web.Administration;

namespace WebAnalyticsModule
{
    /// <summary>
    /// These are helper classes for reading and writing module configuration at design time and runtime.
    /// </summary>

    internal enum InsertionPoint:int
    {
        Head = 0,
        Body = 1,
    }
    
    internal class WebAnalyticsSection : ConfigurationSection
    {

        public WebAnalyticsSection()
        {
        }

        public InsertionPoint InsertionPoint
        {
            get
            {
                return ((InsertionPoint)(base["insertionPoint"]));
            }
            set
            {
                base["insertionPoint"] = ((int)(value));
            }
        }

        public bool TrackingEnabled
        {
            get
            {
                return ((bool)(base["trackingEnabled"]));
            }
            set
            {
                base["trackingEnabled"] = value;
            }
        }

        public string TrackingScript
        {
            get
            {
                return ((string)(base["trackingScript"]));
            }
            set
            {
                base["trackingScript"] = value;
            }
        }
    }
}
