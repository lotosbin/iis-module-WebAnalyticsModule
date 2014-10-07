//
// Copyright © Microsoft Corporation.  All rights reserved.
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.Web.Management.Client;
using Microsoft.Web.Management.Client.Win32;
using Microsoft.Web.Management.Server;

namespace WebAnalyticsModule
{
    [ModulePageIdentifier("469FE578-0D15-47fa-8A24-D4F5CDFE8E0B")]
    public sealed class WebAnalyticsPage: ModuleDialogPage
    {
        private WebAnalyticsProxy _serviceProxy;
        internal WebAnalyticsControl _pageControl = null;
        internal PropertyBag _bag = null;
        bool _hasChanges = false;
        bool _readOnly = false;

        public WebAnalyticsPage()
        {
            IntializeComponent();
        }

        protected override bool ApplyChanges()
        {
            bool appliedChanges = false;

            try
            {
                Cursor.Current = Cursors.WaitCursor;

                _pageControl.GetValues(_bag);

                _serviceProxy.UpdateWebAnalyticsSettings(_bag);

                _pageControl.ResetHasChanges();

                _hasChanges = false;
                appliedChanges = true;
            }
            catch (Exception e)
            {
                DisplayErrorMessage(e, Resources.ResourceManager);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
                Update();
            }

            return appliedChanges;
        }

        protected override bool CanApplyChanges
        {
            get 
            {
                return HasChanges; 
            }
        }

        protected override bool HasChanges
        {
            get
            {
                return _hasChanges;
            }
        }
        
        internal void SetHasChanges(bool hasChanges)
        {
            _hasChanges = hasChanges;
            Update();
        }

        protected override void CancelChanges()
        {
            _pageControl.SetValues(_bag);
            SetHasChanges(false);
        }

        private void IntializeComponent()
        {
            _pageControl = new WebAnalyticsControl( this );

            this.Controls.Add(_pageControl);
        }

        protected override bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
        }

        protected override void OnActivated(bool initialActivation)
        {
            base.OnActivated(initialActivation);

            if (initialActivation)
            {
                _serviceProxy = (WebAnalyticsProxy)CreateProxy(typeof(WebAnalyticsProxy));

                _bag = _serviceProxy.GetWebAnalyticsSettings();
                
                if (_bag != null)
                {
                    _readOnly = (bool)_bag[WebAnalyticsGlobals.isLocked];
                    _pageControl.SetValues(_bag);
                }                    
            }
        }
    }
}
