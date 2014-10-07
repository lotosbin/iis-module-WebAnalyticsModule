//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace WebAnalyticsModule
{
    /// <summary>
    /// This class is used to locate module properties in the configuration property bag.
    /// </summary>
    internal sealed class WebAnalyticsGlobals
    {
        public const int trackingEnabled = 0;
        public const int trackingScript = 1;
        public const int insertionPoint = 2;
        public const int isLocked = 3;
    }

}
